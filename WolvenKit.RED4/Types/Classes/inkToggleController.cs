using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkToggleController : inkButtonController
	{
		[Ordinal(13)] 
		[RED("ToggleChanged")] 
		public inkToggleChangedCallback ToggleChanged
		{
			get => GetPropertyValue<inkToggleChangedCallback>();
			set => SetPropertyValue<inkToggleChangedCallback>(value);
		}

		[Ordinal(14)] 
		[RED("isToggled")] 
		public CBool IsToggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("autoToggleOnInput")] 
		public CBool AutoToggleOnInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkToggleController()
		{
			ToggleChanged = new inkToggleChangedCallback();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
