using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CustomAnimationsHudGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("customAnimations")] public CHandle<WidgetAnimationManager> CustomAnimations { get; set; }
		[Ordinal(8)]  [RED("onSpawnAnimations")] public CArray<CName> OnSpawnAnimations { get; set; }
		[Ordinal(9)]  [RED("defaultLibraryItemName")] public CName DefaultLibraryItemName { get; set; }
		[Ordinal(10)]  [RED("defaultLibraryItemAnchor")] public CEnum<inkEAnchor> DefaultLibraryItemAnchor { get; set; }
		[Ordinal(11)]  [RED("spawnedLibrararyItem")] public wCHandle<inkWidget> SpawnedLibrararyItem { get; set; }
		[Ordinal(12)]  [RED("curentLibraryItemName")] public CName CurentLibraryItemName { get; set; }
		[Ordinal(13)]  [RED("currentLibraryItemAnchor")] public CEnum<inkEAnchor> CurrentLibraryItemAnchor { get; set; }
		[Ordinal(14)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(15)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(16)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }

		public CustomAnimationsHudGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
