using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GogErrorNotificationController : inkWidgetLogicController
	{
		private inkWidgetReference _errorMessageWidget;

		[Ordinal(1)] 
		[RED("errorMessageWidget")] 
		public inkWidgetReference ErrorMessageWidget
		{
			get => GetProperty(ref _errorMessageWidget);
			set => SetProperty(ref _errorMessageWidget, value);
		}
	}
}
