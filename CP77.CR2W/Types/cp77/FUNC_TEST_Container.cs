using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FUNC_TEST_Container : CVariable
	{
		[Ordinal(0)]  [RED("BasePanel")] public inkBasePanelWidgetReference BasePanel { get; set; }
		[Ordinal(1)]  [RED("Compound")] public inkCompoundWidgetReference Compound { get; set; }
		[Ordinal(2)]  [RED("Leaf")] public inkLeafWidgetReference Leaf { get; set; }
		[Ordinal(3)]  [RED("Widget")] public inkWidgetReference Widget { get; set; }

		public FUNC_TEST_Container(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
