using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GOGProfileGameController : gameuiBaseGOGProfileController
	{
		private inkWidgetReference _retryButton;
		private inkWidgetReference _parentContainerWidget;
		private CBool _isFirstLogin;
		private CBool _showingFirstLogin;
		private CBool _canRetry;

		[Ordinal(2)] 
		[RED("retryButton")] 
		public inkWidgetReference RetryButton
		{
			get => GetProperty(ref _retryButton);
			set => SetProperty(ref _retryButton, value);
		}

		[Ordinal(3)] 
		[RED("parentContainerWidget")] 
		public inkWidgetReference ParentContainerWidget
		{
			get => GetProperty(ref _parentContainerWidget);
			set => SetProperty(ref _parentContainerWidget, value);
		}

		[Ordinal(4)] 
		[RED("isFirstLogin")] 
		public CBool IsFirstLogin
		{
			get => GetProperty(ref _isFirstLogin);
			set => SetProperty(ref _isFirstLogin, value);
		}

		[Ordinal(5)] 
		[RED("showingFirstLogin")] 
		public CBool ShowingFirstLogin
		{
			get => GetProperty(ref _showingFirstLogin);
			set => SetProperty(ref _showingFirstLogin, value);
		}

		[Ordinal(6)] 
		[RED("canRetry")] 
		public CBool CanRetry
		{
			get => GetProperty(ref _canRetry);
			set => SetProperty(ref _canRetry, value);
		}
	}
}
