using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleStylesGameController : gameuiWidgetGameController
	{
		private CWeakHandle<inkTextWidget> _stateText;
		private CWeakHandle<inkButtonController> _button1Controller;
		private CWeakHandle<inkButtonController> _button2Controller;

		[Ordinal(2)] 
		[RED("stateText")] 
		public CWeakHandle<inkTextWidget> StateText
		{
			get => GetProperty(ref _stateText);
			set => SetProperty(ref _stateText, value);
		}

		[Ordinal(3)] 
		[RED("button1Controller")] 
		public CWeakHandle<inkButtonController> Button1Controller
		{
			get => GetProperty(ref _button1Controller);
			set => SetProperty(ref _button1Controller, value);
		}

		[Ordinal(4)] 
		[RED("button2Controller")] 
		public CWeakHandle<inkButtonController> Button2Controller
		{
			get => GetProperty(ref _button2Controller);
			set => SetProperty(ref _button2Controller, value);
		}
	}
}
