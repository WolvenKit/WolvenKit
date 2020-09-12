using System.Diagnostics;
using System.IO;
using WolvenKit.W3SavegameEditor.Core.Savegame.Variables;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.VariableParsers
{
    /// <summary>
    /// A set of variables
    /// </summary>
    public class BsVariableParser : VariableParserBase<BsVariable>
    {
        private readonly VariableParser _parser;

        public BsVariableParser(VariableParser parser)
        {
            _parser = parser;
        }

        public override string MagicNumber
        {
            get { return "BS"; }
        }

        public override BsVariable ParseImpl(BinaryReader reader, ref int size)
        {
            short nameStringIndex = reader.ReadInt16();
            string name = Names[nameStringIndex - 1];
            size -= sizeof(short);
            Debug.Assert(size == 0);
            
            return new BsVariable
            {
                Name = name,
                Variables = new Variable[0]
            };
        }
    }
}
