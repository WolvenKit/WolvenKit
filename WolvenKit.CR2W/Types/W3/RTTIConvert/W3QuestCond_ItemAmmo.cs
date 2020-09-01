using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_ItemAmmo : CQuestScriptedCondition
	{
		[Ordinal(0)] [RED("("itemName")] 		public CName ItemName { get; set;}

		[Ordinal(0)] [RED("("ammoQuantity")] 		public CInt32 AmmoQuantity { get; set;}

		[Ordinal(0)] [RED("("comparator")] 		public CEnum<ECompareOp> Comparator { get; set;}

		[Ordinal(0)] [RED("("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(0)] [RED("("ammoListener")] 		public CHandle<W3QuestCond_ItemAmmo_AmmoListener> AmmoListener { get; set;}

		[Ordinal(0)] [RED("("inventoryListener")] 		public CHandle<W3QuestCond_ItemAmmo_InventoryListener> InventoryListener { get; set;}

		public W3QuestCond_ItemAmmo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_ItemAmmo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}