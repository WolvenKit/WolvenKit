using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TechQA_ImageSwappingButtonController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }
		[Ordinal(1)]  [RED("textWidgetPath")] public CName TextWidgetPath { get; set; }

		public TechQA_ImageSwappingButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
