using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TooltipSpecialAbilityDisplay : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("AbilityDescription")] public inkTextWidgetReference AbilityDescription { get; set; }
		[Ordinal(1)]  [RED("AbilityIcon")] public inkImageWidgetReference AbilityIcon { get; set; }
		[Ordinal(2)]  [RED("QualityRoot")] public inkWidgetReference QualityRoot { get; set; }

		public TooltipSpecialAbilityDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
