using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DamageTypeIndicator : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("DamageIconRef")] public inkImageWidgetReference DamageIconRef { get; set; }
		[Ordinal(1)]  [RED("DamageTypeLabelRef")] public inkTextWidgetReference DamageTypeLabelRef { get; set; }

		public DamageTypeIndicator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
