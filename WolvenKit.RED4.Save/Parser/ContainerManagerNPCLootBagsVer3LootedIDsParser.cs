using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class ContainerManagerNPCLootBagsVer3LootedIDs : IParseableBuffer
    {
        public List<ulong> EntityIds { get; set; }


        public ContainerManagerNPCLootBagsVer3LootedIDs()
        {
            EntityIds = new List<ulong>();
        }
    }


    public class ContainerManagerNPCLootBagsVer3LootedIDsParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new ContainerManagerNPCLootBagsVer3LootedIDs();
            var entryCount = br.ReadVLQInt32();
            for (int i = 0; i < entryCount; i++)
            {
                data.EntityIds.Add(br.ReadUInt64());
            }
            node.Data = data;

        }
    }

}
