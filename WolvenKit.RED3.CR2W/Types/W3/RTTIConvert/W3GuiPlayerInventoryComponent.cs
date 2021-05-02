using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GuiPlayerInventoryComponent : W3GuiBaseInventoryComponent
	{
		[Ordinal(1)] [RED("_shopInvCmp")] 		public CHandle<W3GuiShopInventoryComponent> _shopInvCmp { get; set;}

		[Ordinal(2)] [RED("_filterType")] 		public CEnum<EInventoryFilterType> _filterType { get; set;}

		[Ordinal(3)] [RED("_currentItemCategoryType")] 		public CName _currentItemCategoryType { get; set;}

		[Ordinal(4)] [RED("stashMode")] 		public CBool StashMode { get; set;}

		[Ordinal(5)] [RED("bPaperdoll")] 		public CBool BPaperdoll { get; set;}

		[Ordinal(6)] [RED("currentDefaultItemAction")] 		public CEnum<EInventoryActionType> CurrentDefaultItemAction { get; set;}

		[Ordinal(7)] [RED("ignorePosition")] 		public CBool IgnorePosition { get; set;}

		[Ordinal(8)] [RED("filterTagList", 2,0)] 		public CArray<CName> FilterTagList { get; set;}

		[Ordinal(9)] [RED("filterForbiddenTagList", 2,0)] 		public CArray<CName> FilterForbiddenTagList { get; set;}

		[Ordinal(10)] [RED("overrideQuestItemFilters")] 		public CBool OverrideQuestItemFilters { get; set;}

		[Ordinal(11)] [RED("previewItems", 2,0)] 		public CArray<SItemUniqueId> PreviewItems { get; set;}

		[Ordinal(12)] [RED("dyePreviewSlots", 2,0)] 		public CArray<SItemUniqueId> DyePreviewSlots { get; set;}

		public W3GuiPlayerInventoryComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}