using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("distractorType")] public CEnum<EPlaystyleType> DistractorType { get; set; }
		[Ordinal(104)] [RED("basicDistractionDeviceSkillChecks")] public CHandle<EngDemoContainer> BasicDistractionDeviceSkillChecks { get; set; }
		[Ordinal(105)] [RED("effectOnSartNames")] public CArray<CName> EffectOnSartNames { get; set; }
		[Ordinal(106)] [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(107)] [RED("forceAnimationSystem")] public CBool ForceAnimationSystem { get; set; }

		public BasicDistractionDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
