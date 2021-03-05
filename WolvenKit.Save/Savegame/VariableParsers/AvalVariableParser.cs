using System.IO;
using WolvenKit.W3SavegameEditor.Core.Exceptions;
using WolvenKit.W3SavegameEditor.Core.Savegame.Variables;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.VariableParsers
{
    public class AvalVariableParser : VariableParserBase<AvalVariable>
    {
        #region Fields

        private const string FullMagicNumber = "AVAL";

        #endregion Fields

        #region Properties

        public override string MagicNumber
        {
            get { return "AV"; }
        }

        #endregion Properties

        #region Methods

        public override AvalVariable ParseImpl(BinaryReader reader, ref int size)
        {
            short nameIndex = reader.ReadInt16();
            string name = Names[nameIndex - 1];
            short typeIndex = reader.ReadInt16();
            string type = Names[typeIndex - 1];
            size -= 2 * sizeof(short);

            int unknown = reader.ReadInt32();
            size -= sizeof(int);

            var value = ReadValue(reader, type, ref size);

            return new AvalVariable
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
                    "Expected AVAL but read {0} at {1}",
                    magicNumber,
                    reader.BaseStream.Position - 4));
            }

            size -= bytesToRead;
        }

        #endregion Methods
    }
}
