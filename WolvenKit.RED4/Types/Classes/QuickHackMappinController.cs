using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickHackMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("iconWidgetActive")] 
		public inkImageWidgetReference IconWidgetActive
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsIMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsIMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsIMappin>>(value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<GameplayRoleMappinData> Data
		{
			get => GetPropertyValue<CHandle<GameplayRoleMappinData>>();
			set => SetPropertyValue<CHandle<GameplayRoleMappinData>>(value);
		}

		public QuickHackMappinController()
		{
			Bar = new();
			Header = new();
			IconWidgetActive = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
