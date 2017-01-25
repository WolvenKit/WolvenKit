using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using W3SavegameEditor.Core.Savegame.VariableParsers;
using W3SavegameEditor.Core.Savegame.Variables;

namespace W3SavegameEditor.Core.Savegame
{
    public class VariableParser
    {
        private readonly string[] _names;
        private readonly Dictionary<string, VariableParserBase> _magicNumberToParserDictionary;
        private readonly Dictionary<Type, VariableParserBase> _typeToParserDictionary;

        public VariableParser(string[] names)
        {
            _names = names;
            _magicNumberToParserDictionary = new Dictionary<string, VariableParserBase>();
            _typeToParserDictionary = new Dictionary<Type, VariableParserBase>();
        }

        public void RegisterParsers(IEnumerable<VariableParserBase> parsers)
        {
            foreach (var parser in parsers)
            {
                parser.Names = _names;
                _magicNumberToParserDictionary[parser.MagicNumber] = parser;
                _typeToParserDictionary[parser.SupportedType] = parser;
            }
        }

        public T Parse<T>(BinaryReader reader, ref int size) where T : Variable
        {
            var parser = _typeToParserDictionary[typeof (T)];
            parser.Verify(reader, ref size);
            return (T)parser.Parse(reader, ref size);
        }

        [DebuggerHidden]
        public Variable Parse(BinaryReader reader, ref int size)
        {
            string magicNumber = reader.PeekString(2);
            VariableParserBase parser;
            if (_magicNumberToParserDictionary.TryGetValue(magicNumber, out parser))
            {
                parser.Verify(reader, ref size);
                var variable = parser.Parse(reader, ref size);
                return variable;
            }
            else
            {
                //string hexMagicNumber = BitConverter.ToString(Encoding.ASCII.GetBytes(magicNumber));
                //Debug.WriteLine(
                //    "Failed to parse {0} bytes of data at {1}. Magic number was {2}",
                //    size,
                //    reader.BaseStream.Position,
                //    hexMagicNumber);

                var unknownVariable = new UnknownVariable
                {
                    Name = "Unknown",
                    Data = reader.ReadBytes(size)
                };
                size = 0;
                return unknownVariable;
            }
        }
    }

}
