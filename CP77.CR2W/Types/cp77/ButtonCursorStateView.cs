using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ButtonCursorStateView : BaseButtonView
	{
		[Ordinal(2)] [RED("HoverStateName")] public CName HoverStateName { get; set; }
		[Ordinal(3)] [RED("PressStateName")] public CName PressStateName { get; set; }
		[Ordinal(4)] [RED("DefaultStateName")] public CName DefaultStateName { get; set; }

		public ButtonCursorStateView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
