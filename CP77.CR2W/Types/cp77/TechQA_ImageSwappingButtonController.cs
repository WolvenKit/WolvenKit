using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TechQA_ImageSwappingButtonController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }
		[Ordinal(1)]  [RED("textWidgetPath")] public CName TextWidgetPath { get; set; }

		public TechQA_ImageSwappingButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
