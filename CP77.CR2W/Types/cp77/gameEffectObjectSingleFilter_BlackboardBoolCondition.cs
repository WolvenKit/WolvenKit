using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectSingleFilter_BlackboardBoolCondition : gameEffectObjectSingleFilter
	{
		[Ordinal(0)]  [RED("filter")] public CHandle<gameEffectObjectSingleFilter> Filter { get; set; }
		[Ordinal(1)]  [RED("parameter")] public gameEffectInputParameter_Bool Parameter { get; set; }

		public gameEffectObjectSingleFilter_BlackboardBoolCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
