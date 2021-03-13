using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkNavigationOverrideEntry : CVariable
	{
		[Ordinal(0)] [RED("from")] public inkWidgetReference From { get; set; }
		[Ordinal(1)] [RED("direction")] public CEnum<inkDiscreteNavigationDirection> Direction { get; set; }
		[Ordinal(2)] [RED("to")] public inkWidgetReference To { get; set; }

		public inkNavigationOverrideEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
