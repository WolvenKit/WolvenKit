using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkToggleController : inkButtonController
	{
		private inkToggleChangedCallback _toggleChanged;
		private CBool _isToggled;
		private CBool _autoToggleOnInput;

		[Ordinal(10)] 
		[RED("ToggleChanged")] 
		public inkToggleChangedCallback ToggleChanged
		{
			get => GetProperty(ref _toggleChanged);
			set => SetProperty(ref _toggleChanged, value);
		}

		[Ordinal(11)] 
		[RED("isToggled")] 
		public CBool IsToggled
		{
			get => GetProperty(ref _isToggled);
			set => SetProperty(ref _isToggled, value);
		}

		[Ordinal(12)] 
		[RED("autoToggleOnInput")] 
		public CBool AutoToggleOnInput
		{
			get => GetProperty(ref _autoToggleOnInput);
			set => SetProperty(ref _autoToggleOnInput, value);
		}
	}
}
