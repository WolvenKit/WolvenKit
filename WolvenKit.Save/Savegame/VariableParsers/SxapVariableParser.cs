using System.IO;
using WolvenKit.W3SavegameEditor.Core.Exceptions;
using WolvenKit.W3SavegameEditor.Core.Savegame.Variables;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.VariableParsers
{
    public class SxapVariableParser : VariableParserBase<SxapVariable>
    {

        private const string FullMagicNumber = "SXAP";

        public override string MagicNumber
        {
            get { return "SX"; }
        }

        public override SxapVariable ParseImpl(BinaryReader reader, ref int size)
        {
            int typeCode1 = reader.ReadInt32();
            int typeCode2 = reader.ReadInt32();
            int typeCode3 = reader.ReadInt32();
            size -= 3 * sizeof(int);

            return new SxapVariable
            {
                TypeCode1 = typeCode1,
                TypeCode2 = typeCode2,
                TypeCode3 = typeCode3
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
                    "Expected SXAP but read {0} at {1}",
                    magicNumber,
                    reader.BaseStream.Position - 4));
            }

            size -= bytesToRead;
        }
    }
}
