using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseCodexLinkController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("linkImage")] public inkImageWidgetReference LinkImage { get; set; }
		[Ordinal(2)] [RED("linkLabel")] public inkTextWidgetReference LinkLabel { get; set; }
		[Ordinal(3)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public BaseCodexLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
