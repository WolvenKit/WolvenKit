using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseAnimatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(104)] [RED("hasInteraction")] public CBool HasInteraction { get; set; }
		[Ordinal(105)] [RED("randomizeAnimationTime")] public CBool RandomizeAnimationTime { get; set; }
		[Ordinal(106)] [RED("nameForActivation")] public TweakDBID NameForActivation { get; set; }
		[Ordinal(107)] [RED("nameForDeactivation")] public TweakDBID NameForDeactivation { get; set; }

		public BaseAnimatedDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
