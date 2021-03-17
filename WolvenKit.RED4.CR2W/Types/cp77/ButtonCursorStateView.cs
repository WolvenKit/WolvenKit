using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ButtonCursorStateView : BaseButtonView
	{
		private CName _hoverStateName;
		private CName _pressStateName;
		private CName _defaultStateName;

		[Ordinal(2)] 
		[RED("HoverStateName")] 
		public CName HoverStateName
		{
			get => GetProperty(ref _hoverStateName);
			set => SetProperty(ref _hoverStateName, value);
		}

		[Ordinal(3)] 
		[RED("PressStateName")] 
		public CName PressStateName
		{
			get => GetProperty(ref _pressStateName);
			set => SetProperty(ref _pressStateName, value);
		}

		[Ordinal(4)] 
		[RED("DefaultStateName")] 
		public CName DefaultStateName
		{
			get => GetProperty(ref _defaultStateName);
			set => SetProperty(ref _defaultStateName, value);
		}

		public ButtonCursorStateView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
