using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSceneSolutionHash : CVariable
	{
		[Ordinal(0)]  [RED("sceneSolutionHash")] public scnSceneSolutionHashHash SceneSolutionHash { get; set; }

		public scnSceneSolutionHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
