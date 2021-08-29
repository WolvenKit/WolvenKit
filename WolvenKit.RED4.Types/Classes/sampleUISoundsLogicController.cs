using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleUISoundsLogicController : inkWidgetLogicController
	{
		private CWeakHandle<inkTextWidget> _textWidget;

		[Ordinal(1)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}
	}
}
