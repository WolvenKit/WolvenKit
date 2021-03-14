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
			get
			{
				if (_eventDispatcher == null)
				{
					_eventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "eventDispatcher", cr2w, this);
				}
				return _eventDispatcher;
			}
			set
			{
				if (_eventDispatcher == value)
				{
					return;
				}
				_eventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("characterCustomizationState")] 
		public CHandle<gameuiICharacterCustomizationState> CharacterCustomizationState
		{
			get
			{
				if (_characterCustomizationState == null)
				{
					_characterCustomizationState = (CHandle<gameuiICharacterCustomizationState>) CR2WTypeManager.Create("handle:gameuiICharacterCustomizationState", "characterCustomizationState", cr2w, this);
				}
				return _characterCustomizationState;
			}
			set
			{
				if (_characterCustomizationState == value)
				{
					return;
				}
				_characterCustomizationState = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("nextPageHitArea")] 
		public inkWidgetReference NextPageHitArea
		{
			get
			{
				if (_nextPageHitArea == null)
				{
					_nextPageHitArea = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nextPageHitArea", cr2w, this);
				}
				return _nextPageHitArea;
			}
			set
			{
				if (_nextPageHitArea == value)
				{
					return;
				}
				_nextPageHitArea = value;
				PropertySet(this);
			}
		}

		public gameuiBaseCharacterCreationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
