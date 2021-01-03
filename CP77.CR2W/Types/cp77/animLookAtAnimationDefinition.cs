using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animLookAtAnimationDefinition : CVariable
	{
		[Ordinal(0)]  [RED("animDelay")] public CFloat AnimDelay { get; set; }
		[Ordinal(1)]  [RED("animations")] public CArray<CName> Animations { get; set; }
		[Ordinal(2)]  [RED("minTransitionDuration")] public CFloat MinTransitionDuration { get; set; }
		[Ordinal(3)]  [RED("playAnimProbability")] public CFloat PlayAnimProbability { get; set; }

		public animLookAtAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
