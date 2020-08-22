using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GuiPlayerInventoryComponent : W3GuiBaseInventoryComponent
	{
		[RED("_shopInvCmp")] 		public CHandle<W3GuiShopInventoryComponent> _shopInvCmp { get; set;}

		[RED("_filterType")] 		public CEnum<EInventoryFilterType> _filterType { get; set;}

		[RED("_currentItemCategoryType")] 		public CName _currentItemCategoryType { get; set;}

		[RED("stashMode")] 		public CBool StashMode { get; set;}

		[RED("bPaperdoll")] 		public CBool BPaperdoll { get; set;}

		[RED("currentDefaultItemAction")] 		public CEnum<EInventoryActionType> CurrentDefaultItemAction { get; set;}

		[RED("ignorePosition")] 		public CBool IgnorePosition { get; set;}

		[RED("filterTagList", 2,0)] 		public CArray<CName> FilterTagList { get; set;}

		[RED("filterForbiddenTagList", 2,0)] 		public CArray<CName> FilterForbiddenTagList { get; set;}

		[RED("overrideQuestItemFilters")] 		public CBool OverrideQuestItemFilters { get; set;}

		[RED("previewItems", 2,0)] 		public CArray<SItemUniqueId> PreviewItems { get; set;}

		[RED("dyePreviewSlots", 2,0)] 		public CArray<SItemUniqueId> DyePreviewSlots { get; set;}

		public W3GuiPlayerInventoryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3GuiPlayerInventoryComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}