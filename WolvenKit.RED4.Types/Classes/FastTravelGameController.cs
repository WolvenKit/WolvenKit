using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastTravelGameController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _fastTravelPointsList;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;

		[Ordinal(2)] 
		[RED("fastTravelPointsList")] 
		public inkCompoundWidgetReference FastTravelPointsList
		{
			get => GetProperty(ref _fastTravelPointsList);
			set => SetProperty(ref _fastTravelPointsList, value);
		}

		[Ordinal(3)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}
	}
}
