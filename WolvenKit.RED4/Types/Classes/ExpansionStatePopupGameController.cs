using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExpansionStatePopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("statusRef")] 
		public inkTextWidgetReference StatusRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ExpansionStatePopupGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
