using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationContainerSRRef : CVariable
	{
		[Ordinal(0)] [RED("animations")] public CArray<scnRidAnimationContainerSRRefAnimContainer> Animations { get; set; }

		public scnRidAnimationContainerSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
