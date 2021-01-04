using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SceneScreenUIAnimationsData : IScriptable
	{
		[Ordinal(0)]  [RED("customAnimations")] public CHandle<WidgetAnimationManager> CustomAnimations { get; set; }
		[Ordinal(1)]  [RED("defaultLibraryItemAnchor")] public CEnum<inkEAnchor> DefaultLibraryItemAnchor { get; set; }
		[Ordinal(2)]  [RED("defaultLibraryItemName")] public CName DefaultLibraryItemName { get; set; }
		[Ordinal(3)]  [RED("onSpawnAnimations")] public CArray<CName> OnSpawnAnimations { get; set; }

		public SceneScreenUIAnimationsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
