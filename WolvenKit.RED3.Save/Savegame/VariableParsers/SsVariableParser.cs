using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using WolvenKit.W3SavegameEditor.Core.Savegame.Variables;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.VariableParsers
{
    public class SsVariableParser : VariableParserBase<SsVariable>
    {
        #region Fields

        private readonly VariableParser _parser;

        #endregion Fields

        #region Constructors

        public SsVariableParser(VariableParser parser)
        {
            _parser = parser;
        }

        #endregion Constructors

        #region Properties

        public override string MagicNumber
        {
            get { return "SS"; }
        }

        #endregion Properties

        #region Methods

        public override SsVariable ParseImpl(BinaryReader reader, ref int size)
        {
            int sizeInner = reader.ReadInt32();
            size -= sizeof(int);
            Debug.Assert(sizeInner == size);

            List<Variable> variables = new List<Variable>();
            while (size > 0)
            {
                var variable = _parser.Parse(reader, ref size);
                variables.Add(variable);
            }

            Debug.Assert(size == 0);

            return new SsVariable
            {
                Name = "None",
                Variables = variables.ToArray()
            };
        }

        #endregion Methods
    }
}
