using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseToggleView : inkWidgetLogicController
	{
		private CWeakHandle<inkToggleController> _toggleController;
		private CEnum<inkEToggleState> _oldState;

		[Ordinal(1)] 
		[RED("ToggleController")] 
		public CWeakHandle<inkToggleController> ToggleController
		{
			get => GetProperty(ref _toggleController);
			set => SetProperty(ref _toggleController, value);
		}

		[Ordinal(2)] 
		[RED("OldState")] 
		public CEnum<inkEToggleState> OldState
		{
			get => GetProperty(ref _oldState);
			set => SetProperty(ref _oldState, value);
		}
	}
}
