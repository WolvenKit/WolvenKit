using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBaseCharacterCreationController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(4)] 
		[RED("characterCustomizationState")] 
		public CHandle<gameuiICharacterCustomizationState> CharacterCustomizationState
		{
			get => GetPropertyValue<CHandle<gameuiICharacterCustomizationState>>();
			set => SetPropertyValue<CHandle<gameuiICharacterCustomizationState>>(value);
		}

		[Ordinal(5)] 
		[RED("nextPageHitArea")] 
		public inkWidgetReference NextPageHitArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiBaseCharacterCreationController()
		{
			NextPageHitArea = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
