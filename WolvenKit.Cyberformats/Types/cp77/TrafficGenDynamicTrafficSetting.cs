using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TrafficGenDynamicTrafficSetting : CVariable
	{
		[Ordinal(0)] [RED("impact")] public CEnum<TrafficGenDynamicImpact> Impact { get; set; }

		public TrafficGenDynamicTrafficSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
