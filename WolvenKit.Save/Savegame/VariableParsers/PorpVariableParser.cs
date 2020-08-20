using System.Diagnostics;
using System.IO;
using W3SavegameEditor.Core.Exceptions;
using W3SavegameEditor.Core.Savegame.Variables;

namespace W3SavegameEditor.Core.Savegame.VariableParsers
{
    public class PorpVariableParser : VariableParserBase<PorpVariable>
    {
        private const string FullMagicNumber = "PORP";

        public override string MagicNumber
        {
            get { return "PO"; }
        }

        public override PorpVariable ParseImpl(BinaryReader reader, ref int size)
        {
            short nameIndex = reader.ReadInt16();
            string name = Names[nameIndex - 1];

            short typeIndex = reader.ReadInt16();
            string type = Names[typeIndex - 1];

            size -= 2 * sizeof(short);
            
            int valueSize = reader.ReadInt32();
            size -= sizeof(int);

            int readValueSize = valueSize;
            var value = ReadValue(reader, type, ref readValueSize);
            size -= valueSize;
            Debug.Assert(readValueSize == 0);

            return new PorpVariable
            {
                Name = name,
                Type = type,
                Value = value
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
                    "Expeced PORP but read {0} at {1}",
                    magicNumber,
                    reader.BaseStream.Position - 4));
            }

            size -= bytesToRead;
        }
    }
}
