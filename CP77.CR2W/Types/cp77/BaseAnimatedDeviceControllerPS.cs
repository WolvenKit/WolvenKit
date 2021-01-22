using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseAnimatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("hasInteraction")] public CBool HasInteraction { get; set; }
		[Ordinal(1)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(2)]  [RED("nameForActivation")] public TweakDBID NameForActivation { get; set; }
		[Ordinal(3)]  [RED("nameForDeactivation")] public TweakDBID NameForDeactivation { get; set; }
		[Ordinal(4)]  [RED("randomizeAnimationTime")] public CBool RandomizeAnimationTime { get; set; }

		public BaseAnimatedDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
