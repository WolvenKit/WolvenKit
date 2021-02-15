using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ImageSwappingController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("ImageWidgetPath")] public CString ImageWidgetPath { get; set; }
		[Ordinal(2)] [RED("ButtonsPaths")] public CArray<CName> ButtonsPaths { get; set; }
		[Ordinal(3)] [RED("ButtonsNames")] public CArray<CString> ButtonsNames { get; set; }
		[Ordinal(4)] [RED("ButtonsValues")] public CArray<CString> ButtonsValues { get; set; }
		[Ordinal(5)] [RED("Buttons")] public CArray<wCHandle<inkCanvasWidget>> Buttons { get; set; }

		public ImageSwappingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
