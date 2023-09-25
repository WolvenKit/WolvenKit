using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GOGProfileGameController : gameuiBaseGOGProfileController
	{
		[Ordinal(2)] 
		[RED("retryButton")] 
		public inkWidgetReference RetryButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("parentContainerWidget")] 
		public inkWidgetReference ParentContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("isFirstLogin")] 
		public CBool IsFirstLogin
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("showingFirstLogin")] 
		public CBool ShowingFirstLogin
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("canRetry")] 
		public CBool CanRetry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GOGProfileGameController()
		{
			RetryButton = new inkWidgetReference();
			ParentContainerWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
