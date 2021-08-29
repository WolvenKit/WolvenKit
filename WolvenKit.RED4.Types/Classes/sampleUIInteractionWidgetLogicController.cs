using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleUIInteractionWidgetLogicController : inkWidgetLogicController
	{
		private CColor _enableStateColor;
		private CColor _disableStateColor;
		private CWeakHandle<inkTextWidget> _textWidget;

		[Ordinal(1)] 
		[RED("enableStateColor")] 
		public CColor EnableStateColor
		{
			get => GetProperty(ref _enableStateColor);
			set => SetProperty(ref _enableStateColor, value);
		}

		[Ordinal(2)] 
		[RED("disableStateColor")] 
		public CColor DisableStateColor
		{
			get => GetProperty(ref _disableStateColor);
			set => SetProperty(ref _disableStateColor, value);
		}

		[Ordinal(3)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}
	}
}
