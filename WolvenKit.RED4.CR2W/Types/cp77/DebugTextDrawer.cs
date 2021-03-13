using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugTextDrawer : gameObject
	{
		[Ordinal(40)] [RED("text")] public CString Text { get; set; }
		[Ordinal(41)] [RED("color")] public CColor Color { get; set; }

		public DebugTextDrawer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
