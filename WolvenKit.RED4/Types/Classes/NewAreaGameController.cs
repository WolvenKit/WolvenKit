using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewAreaGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<NewAreaDiscoveredUserData> Data
		{
			get => GetPropertyValue<CHandle<NewAreaDiscoveredUserData>>();
			set => SetPropertyValue<CHandle<NewAreaDiscoveredUserData>>(value);
		}

		public NewAreaGameController()
		{
			Label = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
