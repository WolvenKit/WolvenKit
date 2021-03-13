using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomAnimationsGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("customAnimations")] public CHandle<WidgetAnimationManager> CustomAnimations { get; set; }
		[Ordinal(3)] [RED("onSpawnAnimations")] public CArray<CName> OnSpawnAnimations { get; set; }
		[Ordinal(4)] [RED("defaultLibraryItemName")] public CName DefaultLibraryItemName { get; set; }
		[Ordinal(5)] [RED("defaultLibraryItemAnchor")] public CEnum<inkEAnchor> DefaultLibraryItemAnchor { get; set; }
		[Ordinal(6)] [RED("spawnedLibrararyItem")] public wCHandle<inkWidget> SpawnedLibrararyItem { get; set; }
		[Ordinal(7)] [RED("curentLibraryItemName")] public CName CurentLibraryItemName { get; set; }
		[Ordinal(8)] [RED("currentLibraryItemAnchor")] public CEnum<inkEAnchor> CurrentLibraryItemAnchor { get; set; }
		[Ordinal(9)] [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(10)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(11)] [RED("ownerID")] public entEntityID OwnerID { get; set; }

		public CustomAnimationsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
