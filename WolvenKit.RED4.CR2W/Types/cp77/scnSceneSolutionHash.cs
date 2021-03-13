using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneSolutionHash : CVariable
	{
		[Ordinal(0)] [RED("sceneSolutionHash")] public scnSceneSolutionHashHash SceneSolutionHash { get; set; }

		public scnSceneSolutionHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
