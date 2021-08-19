using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVirtualCompoundController : inkDiscreteNavigationController
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

		public inkVirtualCompoundController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
