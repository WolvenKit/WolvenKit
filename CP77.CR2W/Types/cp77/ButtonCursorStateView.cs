using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ButtonCursorStateView : BaseButtonView
	{
		[Ordinal(0)]  [RED("DefaultStateName")] public CName DefaultStateName { get; set; }
		[Ordinal(1)]  [RED("HoverStateName")] public CName HoverStateName { get; set; }
		[Ordinal(2)]  [RED("PressStateName")] public CName PressStateName { get; set; }

		public ButtonCursorStateView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
