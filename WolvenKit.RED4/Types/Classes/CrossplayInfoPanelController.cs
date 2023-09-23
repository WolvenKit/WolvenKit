using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrossplayInfoPanelController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("signOutEnabled")] 
		public CBool SignOutEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("disconnectBtn")] 
		public inkWidgetReference DisconnectBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public CrossplayInfoPanelController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
