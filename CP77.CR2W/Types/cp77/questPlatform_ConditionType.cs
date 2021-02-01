using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPlatform_ConditionType : questISystemConditionType
	{
		[Ordinal(0)]  [RED("platform")] public CEnum<questPlatform> Platform { get; set; }

		public questPlatform_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
