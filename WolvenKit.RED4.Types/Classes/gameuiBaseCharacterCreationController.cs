using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiBaseCharacterCreationController : gameuiMenuGameController
	{
		private CWeakHandle<inkMenuEventDispatcher> _eventDispatcher;
		private CHandle<gameuiICharacterCustomizationState> _characterCustomizationState;
		private inkWidgetReference _nextPageHitArea;

		[Ordinal(3)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetProperty(ref _eventDispatcher);
			set => SetProperty(ref _eventDispatcher, value);
		}

		[Ordinal(4)] 
		[RED("characterCustomizationState")] 
		public CHandle<gameuiICharacterCustomizationState> CharacterCustomizationState
		{
			get => GetProperty(ref _characterCustomizationState);
			set => SetProperty(ref _characterCustomizationState, value);
		}

		[Ordinal(5)] 
		[RED("nextPageHitArea")] 
		public inkWidgetReference NextPageHitArea
		{
			get => GetProperty(ref _nextPageHitArea);
			set => SetProperty(ref _nextPageHitArea, value);
		}
	}
}
