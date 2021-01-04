using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(1)]  [RED("basicDistractionDeviceSkillChecks")] public CHandle<EngDemoContainer> BasicDistractionDeviceSkillChecks { get; set; }
		[Ordinal(2)]  [RED("distractorType")] public CEnum<EPlaystyleType> DistractorType { get; set; }
		[Ordinal(3)]  [RED("effectOnSartNames")] public CArray<CName> EffectOnSartNames { get; set; }
		[Ordinal(4)]  [RED("forceAnimationSystem")] public CBool ForceAnimationSystem { get; set; }

		public BasicDistractionDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
