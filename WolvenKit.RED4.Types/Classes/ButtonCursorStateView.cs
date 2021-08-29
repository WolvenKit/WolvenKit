using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ButtonCursorStateView : BaseButtonView
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
	}
}
