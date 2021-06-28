using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ItemSelectionPopupData : CObject
	{
		[Ordinal(1)] [RED("targetInventory")] 		public CHandle<CInventoryComponent> TargetInventory { get; set;}

		[Ordinal(2)] [RED("filterTagsList", 2,0)] 		public CArray<CName> FilterTagsList { get; set;}

		[Ordinal(3)] [RED("filterForbiddenTagsList", 2,0)] 		public CArray<CName> FilterForbiddenTagsList { get; set;}

		[Ordinal(4)] [RED("categoryFilterList", 2,0)] 		public CArray<CName> CategoryFilterList { get; set;}

		[Ordinal(5)] [RED("collectorTag")] 		public CName CollectorTag { get; set;}

		[Ordinal(6)] [RED("targetItems", 2,0)] 		public CArray<CName> TargetItems { get; set;}

		[Ordinal(7)] [RED("selectionMode")] 		public CEnum<EItemSelectionPopupMode> SelectionMode { get; set;}

		[Ordinal(8)] [RED("overrideQuestItemRestrictions")] 		public CBool OverrideQuestItemRestrictions { get; set;}

		public W3ItemSelectionPopupData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}