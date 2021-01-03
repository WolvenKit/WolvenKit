using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkCompoundWidget : inkWidget
	{
		[Ordinal(0)]  [RED("childMargin")] public inkMargin ChildMargin { get; set; }
		[Ordinal(1)]  [RED("childOrder")] public CEnum<inkEChildOrder> ChildOrder { get; set; }
		[Ordinal(2)]  [RED("children")] public CHandle<inkMultiChildren> Children { get; set; }

		public inkCompoundWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
