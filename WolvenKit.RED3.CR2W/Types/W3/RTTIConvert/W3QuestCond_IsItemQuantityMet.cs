using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_IsItemQuantityMet : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("itemName")] 		public CName ItemName { get; set;}

		[Ordinal(2)] [RED("entityTag")] 		public CName EntityTag { get; set;}

		[Ordinal(3)] [RED("itemTag")] 		public CName ItemTag { get; set;}

		[Ordinal(4)] [RED("itemCategory")] 		public CName ItemCategory { get; set;}

		[Ordinal(5)] [RED("comparator")] 		public CEnum<ECompareOp> Comparator { get; set;}

		[Ordinal(6)] [RED("count")] 		public CInt32 Count { get; set;}

		[Ordinal(7)] [RED("includeHorseInventory")] 		public CBool IncludeHorseInventory { get; set;}

		[Ordinal(8)] [RED("ignoreTags", 2,0)] 		public CArray<CName> IgnoreTags { get; set;}

		[Ordinal(9)] [RED("inventory")] 		public CHandle<CInventoryComponent> Inventory { get; set;}

		[Ordinal(10)] [RED("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(11)] [RED("isTrophy")] 		public CBool IsTrophy { get; set;}

		[Ordinal(12)] [RED("globalListener")] 		public CHandle<W3QuestCond_IsItemQuantityMet_GlobalListener> GlobalListener { get; set;}

		[Ordinal(13)] [RED("inventoryListener")] 		public CHandle<W3QuestCond_IsItemQuantityMet_InventoryListener> InventoryListener { get; set;}

		public W3QuestCond_IsItemQuantityMet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_IsItemQuantityMet(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}