using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSceneSolutionHashHash : CVariable
	{
		[Ordinal(0)]  [RED("sceneSolutionHashDate")] public CUInt64 SceneSolutionHashDate { get; set; }

		public scnSceneSolutionHashHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
