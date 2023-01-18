using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class ContainerManagerNPCLootBagsVer3LootedIDs : INodeData
    {
        public List<ulong> EntityIds { get; set; }


        public ContainerManagerNPCLootBagsVer3LootedIDs()
        {
            EntityIds = new List<ulong>();
        }
    }


    public class ContainerManagerNPCLootBagsVer3LootedIDsParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.CONTAINER_MANAGER_NPC_LOOT_BAGS_VER3_LOOTED_IDS;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new ContainerManagerNPCLootBagsVer3LootedIDs();
            var entryCount = reader.ReadVLQInt32();
            for (int i = 0; i < entryCount; i++)
            {
                data.EntityIds.Add(reader.ReadUInt64());
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (ContainerManagerNPCLootBagsVer3LootedIDs)node.Value;

            writer.WriteVLQInt32(data.EntityIds.Count);
            foreach (var entityId in data.EntityIds)
            {
                writer.Write(entityId);
            }
        }
    }

}
