using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NewGameMenuGameController : PreGameSubMenuGameController
	{
		private CWeakHandle<inkSelectorController> _categories;
		private CWeakHandle<inkSelectorController> _gameDefinitions;
		private CWeakHandle<inkSelectorController> _genders;

		[Ordinal(3)] 
		[RED("categories")] 
		public CWeakHandle<inkSelectorController> Categories
		{
			get => GetProperty(ref _categories);
			set => SetProperty(ref _categories, value);
		}

		[Ordinal(4)] 
		[RED("gameDefinitions")] 
		public CWeakHandle<inkSelectorController> GameDefinitions
		{
			get => GetProperty(ref _gameDefinitions);
			set => SetProperty(ref _gameDefinitions, value);
		}

		[Ordinal(5)] 
		[RED("genders")] 
		public CWeakHandle<inkSelectorController> Genders
		{
			get => GetProperty(ref _genders);
			set => SetProperty(ref _genders, value);
		}
	}
}
