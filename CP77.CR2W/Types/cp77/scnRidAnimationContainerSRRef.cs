using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationContainerSRRef : CVariable
	{
		[Ordinal(0)]  [RED("animations")] public CArray<scnRidAnimationContainerSRRefAnimContainer> Animations { get; set; }

		public scnRidAnimationContainerSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
