using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RipperdocIdPanel : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("NameLabel")] public inkTextWidgetReference NameLabel { get; set; }
		[Ordinal(2)] [RED("MoneyLabel")] public inkTextWidgetReference MoneyLabel { get; set; }

		public RipperdocIdPanel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
