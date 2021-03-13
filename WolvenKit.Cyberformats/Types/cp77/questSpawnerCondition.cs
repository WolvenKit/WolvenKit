using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSpawnerCondition : questTypedCondition
	{
		[Ordinal(0)] [RED("type")] public CHandle<questISpawnerConditionType> Type { get; set; }

		public questSpawnerCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
