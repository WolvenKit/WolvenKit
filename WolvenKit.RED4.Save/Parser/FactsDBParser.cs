using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class FactsDB : IParseableBuffer
    {
        private List<FactsTable> _factsTables;
        private byte[] _trailingBytes;

        public byte FactsTableCount => (byte)_factsTables.Count;

        public List<FactsTable> FactsTables
        {
            get => _factsTables;
            set
            {
                _factsTables = value;
            }
        }

        public byte[] TrailingBytes
        {
            get => _trailingBytes;
            set
            {
                _trailingBytes = value;
            }
        }

        public FactsDB()
        {
            _factsTables = new List<FactsTable>();
        }
    }

    public class FactsDBParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.FACTSDB;

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new FactsDB();
            var count = br.ReadByte();

            // There should be count many children
            if (count != node.Children.Count)
            {
                throw new InvalidDataException($"Expected {count} FactsTable but found {node.Children.Count}.");
            }
            foreach (var child in node.Children)
            {
                var FactsTableParser = new FactsTableParser();
                FactsTableParser.Read(child);
                data.FactsTables.Add((FactsTable)child.Data);
            }
            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
