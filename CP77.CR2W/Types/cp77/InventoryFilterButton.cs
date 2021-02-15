using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryFilterButton : BaseButtonView
	{
		[Ordinal(2)] [RED("Label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(3)] [RED("InputIcon")] public inkImageWidgetReference InputIcon { get; set; }
		[Ordinal(4)] [RED("IntroPlayed")] public CBool IntroPlayed { get; set; }

		public InventoryFilterButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
