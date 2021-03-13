using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkController : inkButtonController
	{
		[Ordinal(10)] [RED("linkAddress")] public CString LinkAddress { get; set; }
		[Ordinal(11)] [RED("defaultColor")] public HDRColor DefaultColor { get; set; }
		[Ordinal(12)] [RED("hoverColor")] public HDRColor HoverColor { get; set; }
		[Ordinal(13)] [RED("IGNORED_COLOR")] public HDRColor IGNORED_COLOR { get; set; }

		public LinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
