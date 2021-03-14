using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtAnimationDefinition : CVariable
	{
		[Ordinal(0)] [RED("minTransitionDuration")] public CFloat MinTransitionDuration { get; set; }
		[Ordinal(1)] [RED("playAnimProbability")] public CFloat PlayAnimProbability { get; set; }
		[Ordinal(2)] [RED("animDelay")] public CFloat AnimDelay { get; set; }
		[Ordinal(3)] [RED("animations")] public CArray<CName> Animations { get; set; }

		public animLookAtAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
