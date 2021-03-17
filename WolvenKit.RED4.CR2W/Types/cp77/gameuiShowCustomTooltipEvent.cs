using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiShowCustomTooltipEvent : redEvent
	{
		private CString _text;
		private CString _inputAction;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(1)] 
		[RED("inputAction")] 
		public CString InputAction
		{
			get => GetProperty(ref _inputAction);
			set => SetProperty(ref _inputAction, value);
		}

		public gameuiShowCustomTooltipEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
