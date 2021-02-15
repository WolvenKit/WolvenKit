using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePhotoModeBackgroundViewComponent : entIComponent
	{
		[Ordinal(3)] [RED("backgroundPrefabRef")] public NodeRef BackgroundPrefabRef { get; set; }
		[Ordinal(4)] [RED("targetPointRef")] public NodeRef TargetPointRef { get; set; }

		public gamePhotoModeBackgroundViewComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
