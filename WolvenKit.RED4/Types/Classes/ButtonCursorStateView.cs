using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ButtonCursorStateView : BaseButtonView
	{
		[Ordinal(5)] 
		[RED("HoverStateName")] 
		public CName HoverStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("PressStateName")] 
		public CName PressStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("DefaultStateName")] 
		public CName DefaultStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ButtonCursorStateView()
		{
			HoverStateName = "Hover";
			PressStateName = "Hover";
			DefaultStateName = "Default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
