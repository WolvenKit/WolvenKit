using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class FactsTable : IParseableBuffer
    {
        private List<FactEntry> _factEntries;

        public class FactEntry
        {
            private uint _hash;
            private uint _value;

            public uint Hash
            {
                get => _hash;
                set
                {
                    _hash = value;
                }
            }

            public string FactName => FactResolver.GetName(Hash);

            public uint Value
            {
                get => _value;
                set
                {
                    _value = value;
                }
            }

            public override string ToString()
            {
                return $"{FactName}";
            }
        }

        public List<FactEntry> FactEntries
        {
            get => _factEntries;
            set
            {
                _factEntries = value;
            }
        }

        public FactsTable()
        {
            _factEntries = new List<FactEntry>();
        }
    }

    public class FactResolver
    {
        static Dictionary<ulong, string> _facts = new Dictionary<ulong, string>();
        public static string GetName(uint hash)
        {
            if (_facts.ContainsKey(hash))
            {
                return _facts[hash];
            }
            return $"Unknown_{hash:X}";
        }
        public static void UseDictionary(Dictionary<ulong, string> dictionary)
        {
            _facts = dictionary;
        }
    }


    public class FactsTableParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new FactsTable();
            var count = br.ReadVLQInt32();

            var tmpFactList = new uint[count];
            for (int i = 0; i < count; i++)
            {
                tmpFactList[i] = br.ReadUInt32();
            }

            for (int i = 0; i < count; i++)
            {
                data.FactEntries.Add(new FactsTable.FactEntry
                {
                    Hash = tmpFactList[i],
                    Value = br.ReadUInt32()
                });
            }
            //TODO: check wether FactsTable nodes have children and which type and then parse
            //ParserUtils.ParseChildren(node.Children, reader, parsers);
            node.Data = data;
        }
    }

}
