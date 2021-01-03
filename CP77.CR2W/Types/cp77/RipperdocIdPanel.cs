using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RipperdocIdPanel : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("MoneyLabel")] public inkTextWidgetReference MoneyLabel { get; set; }
		[Ordinal(1)]  [RED("NameLabel")] public inkTextWidgetReference NameLabel { get; set; }

		public RipperdocIdPanel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
