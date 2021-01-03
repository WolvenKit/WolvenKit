using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryFilterButton : BaseButtonView
	{
		[Ordinal(0)]  [RED("InputIcon")] public inkImageWidgetReference InputIcon { get; set; }
		[Ordinal(1)]  [RED("IntroPlayed")] public CBool IntroPlayed { get; set; }
		[Ordinal(2)]  [RED("Label")] public inkTextWidgetReference Label { get; set; }

		public InventoryFilterButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
