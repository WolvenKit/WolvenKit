using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseCharacterCreationController : gameuiMenuGameController
	{
		private wCHandle<inkMenuEventDispatcher> _eventDispatcher;
		private CHandle<gameuiICharacterCustomizationState> _characterCustomizationState;
		private inkWidgetReference _nextPageHitArea;

		[Ordinal(3)] 
		[RED("eventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> EventDispatcher
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

		public gameuiBaseCharacterCreationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
