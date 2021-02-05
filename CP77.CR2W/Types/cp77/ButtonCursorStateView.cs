using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ButtonCursorStateView : BaseButtonView
	{
		[Ordinal(0)]  [RED("ButtonController")] public wCHandle<inkButtonController> ButtonController { get; set; }
		[Ordinal(1)]  [RED("HoverStateName")] public CName HoverStateName { get; set; }
		[Ordinal(2)]  [RED("PressStateName")] public CName PressStateName { get; set; }
		[Ordinal(3)]  [RED("DefaultStateName")] public CName DefaultStateName { get; set; }

		public ButtonCursorStateView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
