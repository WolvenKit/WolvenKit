using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CustomAnimationsHudGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("customAnimations")] public CHandle<WidgetAnimationManager> CustomAnimations { get; set; }
		[Ordinal(10)] [RED("onSpawnAnimations")] public CArray<CName> OnSpawnAnimations { get; set; }
		[Ordinal(11)] [RED("defaultLibraryItemName")] public CName DefaultLibraryItemName { get; set; }
		[Ordinal(12)] [RED("defaultLibraryItemAnchor")] public CEnum<inkEAnchor> DefaultLibraryItemAnchor { get; set; }
		[Ordinal(13)] [RED("spawnedLibrararyItem")] public wCHandle<inkWidget> SpawnedLibrararyItem { get; set; }
		[Ordinal(14)] [RED("curentLibraryItemName")] public CName CurentLibraryItemName { get; set; }
		[Ordinal(15)] [RED("currentLibraryItemAnchor")] public CEnum<inkEAnchor> CurrentLibraryItemAnchor { get; set; }
		[Ordinal(16)] [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(17)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(18)] [RED("ownerID")] public entEntityID OwnerID { get; set; }

		public CustomAnimationsHudGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
