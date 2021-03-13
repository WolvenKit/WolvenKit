using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayBreathingAnimationEffector : gameEffector
	{
		[Ordinal(0)] [RED("animFeature")] public CHandle<AnimFeature_CameraBreathing> AnimFeature { get; set; }
		[Ordinal(1)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(2)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public PlayBreathingAnimationEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
