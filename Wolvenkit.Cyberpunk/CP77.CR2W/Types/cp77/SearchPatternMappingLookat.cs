using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SearchPatternMappingLookat : AISearchingLookat
	{
		[Ordinal(0)]  [RED("lookatTargetObject")] public wCHandle<gameObject> LookatTargetObject { get; set; }
		[Ordinal(1)]  [RED("targetObjectMapping")] public CHandle<AIArgumentMapping> TargetObjectMapping { get; set; }

		public SearchPatternMappingLookat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
