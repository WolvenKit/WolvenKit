using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneSolutionHashHash : CVariable
	{
		[Ordinal(0)] [RED("sceneSolutionHashDate")] public CUInt64 SceneSolutionHashDate { get; set; }

		public scnSceneSolutionHashHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
