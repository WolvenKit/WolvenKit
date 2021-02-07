using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLaunchParams : CVariable
	{
		[Ordinal(0)]  [RED("launchMode")] public CEnum<gameprojectileELaunchMode> LaunchMode { get; set; }
		[Ordinal(1)]  [RED("logicalPositionProvider")] public CHandle<entIPositionProvider> LogicalPositionProvider { get; set; }
		[Ordinal(2)]  [RED("logicalOrientationProvider")] public CHandle<entIOrientationProvider> LogicalOrientationProvider { get; set; }
		[Ordinal(3)]  [RED("visualPositionProvider")] public CHandle<entIPositionProvider> VisualPositionProvider { get; set; }
		[Ordinal(4)]  [RED("visualOrientationProvider")] public CHandle<entIOrientationProvider> VisualOrientationProvider { get; set; }
		[Ordinal(5)]  [RED("ownerVelocityProvider")] public CHandle<entIVelocityProvider> OwnerVelocityProvider { get; set; }

		public gameprojectileLaunchParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
