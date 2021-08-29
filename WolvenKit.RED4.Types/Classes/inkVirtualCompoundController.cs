using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVirtualCompoundController : inkDiscreteNavigationController
	{
		private inkVirtualCompoundControllerCallback _itemSelected;
		private inkVirtualCompoundControllerCallback _itemActivated;
		private inkEmptyCallback _allElementsSpawned;

		[Ordinal(4)] 
		[RED("ItemSelected")] 
		public inkVirtualCompoundControllerCallback ItemSelected
		{
			get => GetProperty(ref _itemSelected);
			set => SetProperty(ref _itemSelected, value);
		}

		[Ordinal(5)] 
		[RED("ItemActivated")] 
		public inkVirtualCompoundControllerCallback ItemActivated
		{
			get => GetProperty(ref _itemActivated);
			set => SetProperty(ref _itemActivated, value);
		}

		[Ordinal(6)] 
		[RED("AllElementsSpawned")] 
		public inkEmptyCallback AllElementsSpawned
		{
			get => GetProperty(ref _allElementsSpawned);
			set => SetProperty(ref _allElementsSpawned, value);
		}
	}
}
