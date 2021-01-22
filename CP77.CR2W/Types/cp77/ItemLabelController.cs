using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemLabelController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(1)]  [RED("moneyIcon")] public inkImageWidgetReference MoneyIcon { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<ItemLabelType> Type { get; set; }

		public ItemLabelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
