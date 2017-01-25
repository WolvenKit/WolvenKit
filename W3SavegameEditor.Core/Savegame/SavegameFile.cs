using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3SavegameEditor.Core.ChunkedLz4;
using W3SavegameEditor.Core.Common;
using W3SavegameEditor.Core.Exceptions;
using W3SavegameEditor.Core.Savegame.Values;
using W3SavegameEditor.Core.Savegame.VariableParsers;
using W3SavegameEditor.Core.Savegame.Variables;

namespace W3SavegameEditor.Core.Savegame
{

    public class SavegameFile
    {
        private class RbEntry
        {
            public short Size { get; set; }
            public int Offset { get; set; }
        }

        [Flags]
        private enum SizeFlag
        {
            Unknown1 = 0x1,
            Unknown2 = 0x2,
            Unknown3 = 0x8000,
            Unknown4 = 0x1000000,
        }

        /// <summary>
        /// Flags that determine the size of certain values.
        /// </summary>
        private const SizeFlag DefaultFlags = SizeFlag.Unknown2 | SizeFlag.Unknown3 | SizeFlag.Unknown4;

        public int TypeCode1 { get; set; }
        public int TypeCode2 { get; set; }
        public int TypeCode3 { get; set; }

        public long HeaderStartOffset { get; set; }
        public int VariableTableOffset { get; set; }
        public int StringTableFooterOffset { get; set; }
        public int StringTableOffset { get; set; }
        public int RbSectionOffset { get; set; }
        public int NmSectionOffset { get; set; }

        public VariableTableEntry[] VariableTableEntries { get; set; }
        public string[] VariableNames { get; set; }
        public Variable[] Variables { get; set; }

        public static Task<SavegameFile> ReadAsync(
            string path,
            IReadSavegameProgress progress = null)
        {
            return Task.Run(() => Read(path, progress));
        }

        public static SavegameFile Read(
            string path,
            IReadSavegameProgress progress = null)
        {

            if (progress != null) progress.Report(true, true, 0, 0);
            using (var compressedInputStream = File.OpenRead(path))
            using (var inputStream = ChunkedLz4File.Decompress(compressedInputStream))
            using (var reader = new BinaryReader(inputStream, Encoding.ASCII, true))
            {
                var savegameFile = new SavegameFile();
                savegameFile.ReadHeader(reader);
                savegameFile.ReadFooter(reader);
                savegameFile.ReadStringTable(reader);
                savegameFile.ReadVariableTable(reader);
                if (progress != null) progress.Report(true, false, 0, savegameFile.VariableTableEntries.Length);
                savegameFile.ReadVariables(reader, progress);
                savegameFile.ReferenceVariable(reader, progress);
                if (progress != null) progress.Report(false, false, 0, 0);
                return savegameFile;
            }
        }
        
        private void ReadVariables(BinaryReader reader, IReadSavegameProgress progress)
        {
            var parser = new VariableParser(VariableNames);

            // TODO: Use while loops in each of the recursive parsers
            var parsers = new List<VariableParserBase>
            {
                new ManuVariableParser(),
                new OpVariableParser(),
                new VlVariableParser(),
                new AvalVariableParser(),
                new PorpVariableParser(),
                new SxapVariableParser(),
                new SsVariableParser(parser),
                new BsVariableParser(parser),
                new BlckVariableParser(parser)
            };
            parser.RegisterParsers(parsers);

            Variable[] variables = new Variable[VariableTableEntries.Length];
            for (int i = 0; i < VariableTableEntries.Length; i++)
            {
                // Calculate the size of the next token
                var size = VariableTableEntries[i].Size;
                int tokenSize;

                // There is a hidden variable before the last one
                if (i < VariableTableEntries.Length - 2)
                {
                    tokenSize = VariableTableEntries[i + 1].Offset - VariableTableEntries[i].Offset;
                }
                else
                {
                    tokenSize = VariableTableEntries[i].Size;
                }

                reader.BaseStream.Position = VariableTableEntries[i].Offset;
                try
                {
                    // Tokenizing
                    var readTokenSize = tokenSize;
                    var variable = parser.Parse(reader, ref readTokenSize);
                    variable.Size = size;
                    variable.TokenSize = tokenSize;
                    variables[i] = variable;
                }
                catch (ParseVariableException e)
                {
                    Debug.WriteLine(e.Message);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }

                if (i % 250 == 0 && progress != null) progress.Report(true, false, i, VariableTableEntries.Length);
            }

            // Parsing
            var valueParser = new VariableValueParser();
            var stack = new Stack<Variable>(variables.Reverse());
            var root = valueParser.Parse<SavegameRoot>(stack);
            Variables = variables;
        }

        private void ReferenceVariable(BinaryReader reader, IReadSavegameProgress progress)
        {
            List<Variable> referencedVariables = new List<Variable>();
            for (int i = 0; i < Variables.Length; i++)
            {
                Variable currentVariable = Variables[i];
                VariableSet currentVariableSet = currentVariable as VariableSet;
                if (currentVariableSet!= null && currentVariable.Size > currentVariable.TokenSize)
                {
                    int size = currentVariable.Size - currentVariableSet.TokenSize;
                    List<Variable> childrenVariables = new List<Variable>();
                    while (size > 0)
                    {
                        Variable nextVariable = Variables[++i];
                        childrenVariables.Add(nextVariable);
                        size -= nextVariable.TokenSize;
                    }
                    currentVariableSet.Variables = childrenVariables.ToArray();
                }

                referencedVariables.Add(currentVariable);
            }

            Variables = referencedVariables.ToArray();
        }

        private void ReadVariableTable(BinaryReader reader)
        {
            reader.BaseStream.Seek(VariableTableOffset, SeekOrigin.Begin);
            int entryCount = reader.ReadInt32();
            VariableTableEntry[] entires = new VariableTableEntry[entryCount];
            for (int i = 0; i < entryCount; i++)
            {
                entires[i] = new VariableTableEntry
                {
                    Offset = reader.ReadInt32(),
                    Size = reader.ReadInt32()
                };

                //Debug.WriteLine(entires[i]);

            }

            // Order all variables by their offset to calculate their actual size.
            VariableTableEntries = entires.OrderBy(e => e.Offset).ToArray();
        }

        private void ReadFooter(BinaryReader reader)
        {
            reader.BaseStream.Seek(-6, SeekOrigin.End);
            VariableTableOffset = reader.ReadInt32();
            StringTableFooterOffset = VariableTableOffset - 10;
            string magicNumber = reader.ReadString(2);
            if (magicNumber != "SE")
            {
                throw new InvalidOperationException();
            }
        }

        private void ReadStringTable(BinaryReader reader)
        {
            reader.BaseStream.Position = StringTableFooterOffset;
            NmSectionOffset = reader.ReadInt32();
            RbSectionOffset = reader.ReadInt32();
            ReadNmSection(reader);
            ReadRbSection(reader);
            ReadVariableNameSection(reader);
        }

        private void ReadVariableNameSection(BinaryReader reader)
        {
            reader.BaseStream.Position = StringTableOffset;
            var manuVariableParser = new ManuVariableParser();
            var manuVariableSize = StringTableFooterOffset - StringTableOffset;
            manuVariableParser.Verify(reader, ref manuVariableSize);
            var manuVariable = manuVariableParser.ParseImpl(reader, ref manuVariableSize);
            VariableNames = manuVariable.Strings;
        }

        private void ReadNmSection(BinaryReader reader)
        {
            reader.BaseStream.Position = NmSectionOffset;
            string magicNumber = reader.ReadString(2);
            if (magicNumber != "NM")
            {
                throw new InvalidOperationException();
            }
            StringTableOffset = (int)reader.BaseStream.Position;
        }

        private void ReadRbSection(BinaryReader reader)
        {
            reader.BaseStream.Position = RbSectionOffset;
            string magicNumber = reader.ReadString(2);
            if (magicNumber != "RB")
            {
                throw new InvalidOperationException();
            }
            int count = reader.ReadInt32();
            RbEntry[] rbEntries = new RbEntry[count];
            for (int i = 0; i < count; i++)
            {
                rbEntries[i] = new RbEntry
                {
                    Size = reader.ReadInt16(),
                    Offset = reader.ReadInt32()
                };
            }
        }

        private void ReadHeader(BinaryReader reader)
        {
            HeaderStartOffset = reader.BaseStream.Position;
            string magicNumber = reader.ReadString(4);
            if (magicNumber != "SAV3")
            {
                throw new InvalidOperationException();
            }

            TypeCode1 = reader.ReadInt32();
            //if (TypeCode1 != 54)
            //{
            //    throw new InvalidOperationException();
            //}

            TypeCode2 = reader.ReadInt32();
            //if (TypeCode2 != 10)
            //{
            //    throw new InvalidOperationException();
            //}

            TypeCode3 = reader.ReadInt32();
            //if (TypeCode3 != 162)
            //{
            //    throw new InvalidOperationException();
            //}
        }
    }
}
