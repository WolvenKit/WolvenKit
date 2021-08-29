using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseButtonView : inkWidgetLogicController
	{
		private CWeakHandle<inkButtonController> _buttonController;

		[Ordinal(1)] 
		[RED("ButtonController")] 
		public CWeakHandle<inkButtonController> ButtonController
		{
			get => GetProperty(ref _buttonController);
			set => SetProperty(ref _buttonController, value);
		}
	}
}
