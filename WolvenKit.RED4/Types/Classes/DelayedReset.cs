using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedReset : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<CraftingLogicController> Controller
		{
			get => GetPropertyValue<CWeakHandle<CraftingLogicController>>();
			set => SetPropertyValue<CWeakHandle<CraftingLogicController>>(value);
		}

		public DelayedReset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
