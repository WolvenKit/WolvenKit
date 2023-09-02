using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkButtonController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ButtonClick")] 
		public inkButtonClickCallback ButtonClick
		{
			get => GetPropertyValue<inkButtonClickCallback>();
			set => SetPropertyValue<inkButtonClickCallback>(value);
		}

		[Ordinal(2)] 
		[RED("ButtonHoldComplete")] 
		public inkButtonHoldCompleteCallback ButtonHoldComplete
		{
			get => GetPropertyValue<inkButtonHoldCompleteCallback>();
			set => SetPropertyValue<inkButtonHoldCompleteCallback>(value);
		}

		[Ordinal(3)] 
		[RED("ButtonStateChanged")] 
		public inkButtonStateChangeCallback ButtonStateChanged
		{
			get => GetPropertyValue<inkButtonStateChangeCallback>();
			set => SetPropertyValue<inkButtonStateChangeCallback>(value);
		}

		[Ordinal(4)] 
		[RED("ButtonSelectionChanged")] 
		public inkButtonSelectionCallback ButtonSelectionChanged
		{
			get => GetPropertyValue<inkButtonSelectionCallback>();
			set => SetPropertyValue<inkButtonSelectionCallback>(value);
		}

		[Ordinal(5)] 
		[RED("ButtonHoldProgressChanged")] 
		public inkButtonProgressChangedCallback ButtonHoldProgressChanged
		{
			get => GetPropertyValue<inkButtonProgressChangedCallback>();
			set => SetPropertyValue<inkButtonProgressChangedCallback>(value);
		}

		[Ordinal(6)] 
		[RED("canHold")] 
		public CBool CanHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("selectable")] 
		public CBool Selectable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("selected")] 
		public CBool Selected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("autoUpdateWidgetState")] 
		public CBool AutoUpdateWidgetState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkButtonController()
		{
			ButtonClick = new inkButtonClickCallback();
			ButtonHoldComplete = new inkButtonHoldCompleteCallback();
			ButtonStateChanged = new inkButtonStateChangeCallback();
			ButtonSelectionChanged = new inkButtonSelectionCallback();
			ButtonHoldProgressChanged = new inkButtonProgressChangedCallback();
			AutoUpdateWidgetState = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
