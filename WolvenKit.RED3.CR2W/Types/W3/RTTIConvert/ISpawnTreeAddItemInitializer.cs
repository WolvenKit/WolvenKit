using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ISpawnTreeAddItemInitializer : ISpawnTreeScriptedInitializer
	{
		[Ordinal(1)] [RED("items", 2,0)] 		public CArray<SItemExt> Items { get; set;}

		[Ordinal(2)] [RED("randomize")] 		public CBool Randomize { get; set;}

		[Ordinal(3)] [RED("equip")] 		public CBool Equip { get; set;}

		[Ordinal(4)] [RED("checkIfItemsAlreadyAdded")] 		public CBool CheckIfItemsAlreadyAdded { get; set;}

		[Ordinal(5)] [RED("inventory")] 		public CHandle<CInventoryComponent> Inventory { get; set;}

		[Ordinal(6)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(7)] [RED("rand")] 		public CInt32 Rand { get; set;}

		[Ordinal(8)] [RED("randRange")] 		public CInt32 RandRange { get; set;}

		[Ordinal(9)] [RED("itemsIDs", 2,0)] 		public CArray<SItemUniqueId> ItemsIDs { get; set;}

		[Ordinal(10)] [RED("possesedItemsCount")] 		public CInt32 PossesedItemsCount { get; set;}

		[Ordinal(11)] [RED("itemsToAddCount")] 		public CInt32 ItemsToAddCount { get; set;}

		public ISpawnTreeAddItemInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ISpawnTreeAddItemInitializer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}