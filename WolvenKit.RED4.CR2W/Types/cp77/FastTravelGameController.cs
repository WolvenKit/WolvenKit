using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelGameController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _fastTravelPointsList;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;

		[Ordinal(2)] 
		[RED("fastTravelPointsList")] 
		public inkCompoundWidgetReference FastTravelPointsList
		{
			get => GetProperty(ref _fastTravelPointsList);
			set => SetProperty(ref _fastTravelPointsList, value);
		}

		[Ordinal(3)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		public FastTravelGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
