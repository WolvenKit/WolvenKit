using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkToggleController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("ToggleChanged")] 
		public inkToggleChangedCallback ToggleChanged
		{
			get => GetPropertyValue<inkToggleChangedCallback>();
			set => SetPropertyValue<inkToggleChangedCallback>(value);
		}

		[Ordinal(11)] 
		[RED("isToggled")] 
		public CBool IsToggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("autoToggleOnInput")] 
		public CBool AutoToggleOnInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkToggleController()
		{
			ToggleChanged = new();
		}
	}
}
