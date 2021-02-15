using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HighLevelStateMapping : ChangeHighLevelStateAbstract
	{
		[Ordinal(0)] [RED("stateNameMapping")] public CHandle<AIArgumentMapping> StateNameMapping { get; set; }

		public HighLevelStateMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
