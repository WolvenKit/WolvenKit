using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewGameMenuGameController : PreGameSubMenuGameController
	{
		private wCHandle<inkSelectorController> _categories;
		private wCHandle<inkSelectorController> _gameDefinitions;
		private wCHandle<inkSelectorController> _genders;

		[Ordinal(3)] 
		[RED("categories")] 
		public wCHandle<inkSelectorController> Categories
		{
			get
			{
				if (_categories == null)
				{
					_categories = (wCHandle<inkSelectorController>) CR2WTypeManager.Create("whandle:inkSelectorController", "categories", cr2w, this);
				}
				return _categories;
			}
			set
			{
				if (_categories == value)
				{
					return;
				}
				_categories = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("gameDefinitions")] 
		public wCHandle<inkSelectorController> GameDefinitions
		{
			get
			{
				if (_gameDefinitions == null)
				{
					_gameDefinitions = (wCHandle<inkSelectorController>) CR2WTypeManager.Create("whandle:inkSelectorController", "gameDefinitions", cr2w, this);
				}
				return _gameDefinitions;
			}
			set
			{
				if (_gameDefinitions == value)
				{
					return;
				}
				_gameDefinitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("genders")] 
		public wCHandle<inkSelectorController> Genders
		{
			get
			{
				if (_genders == null)
				{
					_genders = (wCHandle<inkSelectorController>) CR2WTypeManager.Create("whandle:inkSelectorController", "genders", cr2w, this);
				}
				return _genders;
			}
			set
			{
				if (_genders == value)
				{
					return;
				}
				_genders = value;
				PropertySet(this);
			}
		}

		public NewGameMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
