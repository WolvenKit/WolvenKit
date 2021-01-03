using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CustomAnimationsHudGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("curentLibraryItemName")] public CName CurentLibraryItemName { get; set; }
		[Ordinal(1)]  [RED("currentLibraryItemAnchor")] public CEnum<inkEAnchor> CurrentLibraryItemAnchor { get; set; }
		[Ordinal(2)]  [RED("customAnimations")] public CHandle<WidgetAnimationManager> CustomAnimations { get; set; }
		[Ordinal(3)]  [RED("defaultLibraryItemAnchor")] public CEnum<inkEAnchor> DefaultLibraryItemAnchor { get; set; }
		[Ordinal(4)]  [RED("defaultLibraryItemName")] public CName DefaultLibraryItemName { get; set; }
		[Ordinal(5)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(6)]  [RED("onSpawnAnimations")] public CArray<CName> OnSpawnAnimations { get; set; }
		[Ordinal(7)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(8)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(9)]  [RED("spawnedLibrararyItem")] public wCHandle<inkWidget> SpawnedLibrararyItem { get; set; }

		public CustomAnimationsHudGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
