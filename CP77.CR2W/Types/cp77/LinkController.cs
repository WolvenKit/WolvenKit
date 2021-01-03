using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LinkController : inkButtonController
	{
		[Ordinal(0)]  [RED("IGNORED_COLOR")] public HDRColor IGNORED_COLOR { get; set; }
		[Ordinal(1)]  [RED("defaultColor")] public HDRColor DefaultColor { get; set; }
		[Ordinal(2)]  [RED("hoverColor")] public HDRColor HoverColor { get; set; }
		[Ordinal(3)]  [RED("linkAddress")] public CString LinkAddress { get; set; }

		public LinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
