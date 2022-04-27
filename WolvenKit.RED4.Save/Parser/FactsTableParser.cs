using System.Diagnostics;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public sealed class Fact
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _value;

        private uint _hash;


        private Fact(string val)
        {
            _value = val;
            _hash = CalculateHash();
        }

        private Fact(uint value)
        {
            _value = null;
            _hash = value;
        }

        private uint CalculateHash() => FNV1A32HashAlgorithm.HashString(_value);


        public static implicit operator Fact(string value) => new(value);
        public static implicit operator string(Fact value) => value._value;

        public static implicit operator Fact(uint value) => new(value);
        public static implicit operator uint(Fact value) => value._hash;

        public override string ToString()
        {
            return $"{_value}";
        }
    }

    public class FactsTable : INodeData
    {
        private List<FactEntry> _factEntries;

        public class FactEntry
        {
            public Fact FactName { get; set; }
            public uint Value { get; set; }

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
        public static string NodeName => Constants.NodeNames.FACTS_TABLE;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new FactsTable();
            var count = reader.ReadVLQInt32();

            var tmpFactList = new Fact[count];
            for (int i = 0; i < count; i++)
            {
                tmpFactList[i] = reader.ReadFact();
            }

            for (int i = 0; i < count; i++)
            {
                data.FactEntries.Add(new FactsTable.FactEntry
                {
                    FactName = tmpFactList[i],
                    Value = reader.ReadUInt32()
                });
            }
            //TODO: check wether FactsTable nodes have children and which type and then parse
            //ParserUtils.ParseChildren(node.Children, reader, parsers);

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (FactsTable)node.Value;

            writer.WriteVLQInt32(data.FactEntries.Count);

            // Sort FactEntries by their hash before writing
            data.FactEntries = new List<FactsTable.FactEntry>(data.FactEntries.OrderBy(_ => (uint)_.FactName));

            foreach (var fact in data.FactEntries)
            {
                writer.Write((uint)fact.FactName);
            }

            foreach (var fact in data.FactEntries)
            {
                writer.Write(fact.Value);
            }
        }
    }

}
