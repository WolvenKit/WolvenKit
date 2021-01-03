using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkNavigationOverrideEntry : CVariable
	{
		[Ordinal(0)]  [RED("direction")] public CEnum<inkDiscreteNavigationDirection> Direction { get; set; }
		[Ordinal(1)]  [RED("from")] public inkWidgetReference From { get; set; }
		[Ordinal(2)]  [RED("to")] public inkWidgetReference To { get; set; }

		public inkNavigationOverrideEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
