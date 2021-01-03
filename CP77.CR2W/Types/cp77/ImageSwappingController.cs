using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ImageSwappingController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("Buttons")] public CArray<wCHandle<inkCanvasWidget>> Buttons { get; set; }
		[Ordinal(1)]  [RED("ButtonsNames")] public CArray<CString> ButtonsNames { get; set; }
		[Ordinal(2)]  [RED("ButtonsPaths")] public CArray<CName> ButtonsPaths { get; set; }
		[Ordinal(3)]  [RED("ButtonsValues")] public CArray<CString> ButtonsValues { get; set; }
		[Ordinal(4)]  [RED("ImageWidgetPath")] public CString ImageWidgetPath { get; set; }

		public ImageSwappingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
