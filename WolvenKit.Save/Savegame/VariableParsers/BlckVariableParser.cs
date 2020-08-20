using System.Collections.Generic;
using System.IO;
using W3SavegameEditor.Core.Exceptions;
using W3SavegameEditor.Core.Savegame.Variables;

namespace W3SavegameEditor.Core.Savegame.VariableParsers
{
    public class BlckVariableParser : VariableParserBase<BlckVariable>
    {
        private const string FullMagicNumber = "BLCK";

        private readonly VariableParser _parser;
        
        public BlckVariableParser(VariableParser parser)
        {
            _parser = parser;
        }

        public override string MagicNumber
        {
            get { return "BL"; }
        }

        public override BlckVariable ParseImpl(BinaryReader reader, ref int size)
        {
            ushort nameIndex = reader.ReadUInt16();
            string name = Names[nameIndex - 1];
            ushort blckSize = reader.ReadUInt16();
            ushort unknown3 = reader.ReadUInt16();
            size -= 3 * sizeof(short);

            // TODO: Only read blckSize
            List<Variable> variables = new List<Variable>();

            Variable debugLastVariable = null;
            long debugStartPos = reader.BaseStream.Position;
            int debugIndex = 0;
            while (size > 0)
            {
                var variable = _parser.Parse(reader, ref size);
                variables.Add(variable);

                debugLastVariable = variable;
                debugIndex++;
            }
            
            return new BlckVariable
            {
                Name = name,
                Variables = variables.ToArray()
            };
        }

        public override void Verify(BinaryReader reader, ref int size)
        {
            var bytesToRead = FullMagicNumber.Length;
            var magicNumber = reader.ReadString(bytesToRead);
            if (magicNumber != FullMagicNumber)
            {
                throw new ParseVariableException(
                    string.Format(
                    "Expeced BLCK but read {0} at {1}",
                    magicNumber,
                    reader.BaseStream.Position - 4));
            }

            size -= bytesToRead;
        }
    }
}
