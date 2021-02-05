using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCompoundWidget : inkWidget
	{
		[Ordinal(0)]  [RED("childOrder")] public CEnum<inkEChildOrder> ChildOrder { get; set; }
		[Ordinal(1)]  [RED("children")] public CHandle<inkMultiChildren> Children { get; set; }
		[Ordinal(2)]  [RED("childMargin")] public inkMargin ChildMargin { get; set; }

		public inkCompoundWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
