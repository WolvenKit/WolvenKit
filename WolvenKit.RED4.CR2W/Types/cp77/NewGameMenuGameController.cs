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
			get => GetProperty(ref _categories);
			set => SetProperty(ref _categories, value);
		}

		[Ordinal(4)] 
		[RED("gameDefinitions")] 
		public wCHandle<inkSelectorController> GameDefinitions
		{
			get => GetProperty(ref _gameDefinitions);
			set => SetProperty(ref _gameDefinitions, value);
		}

		[Ordinal(5)] 
		[RED("genders")] 
		public wCHandle<inkSelectorController> Genders
		{
			get => GetProperty(ref _genders);
			set => SetProperty(ref _genders, value);
		}

		public NewGameMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
