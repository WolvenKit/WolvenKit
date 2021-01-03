using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DisassemblePopupLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(1)]  [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(2)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(3)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(4)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(5)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(6)]  [RED("quantity")] public inkTextWidgetReference Quantity { get; set; }

		public DisassemblePopupLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
