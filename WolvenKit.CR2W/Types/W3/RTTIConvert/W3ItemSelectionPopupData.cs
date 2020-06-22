using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ItemSelectionPopupData : CObject
	{
		[RED("targetInventory")] 		public CHandle<CInventoryComponent> TargetInventory { get; set;}

		[RED("filterTagsList", 2,0)] 		public CArray<CName> FilterTagsList { get; set;}

		[RED("filterForbiddenTagsList", 2,0)] 		public CArray<CName> FilterForbiddenTagsList { get; set;}

		[RED("categoryFilterList", 2,0)] 		public CArray<CName> CategoryFilterList { get; set;}

		[RED("collectorTag")] 		public CName CollectorTag { get; set;}

		[RED("targetItems", 2,0)] 		public CArray<CName> TargetItems { get; set;}

		[RED("selectionMode")] 		public CEnum<EItemSelectionPopupMode> SelectionMode { get; set;}

		[RED("overrideQuestItemRestrictions")] 		public CBool OverrideQuestItemRestrictions { get; set;}

		public W3ItemSelectionPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ItemSelectionPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}