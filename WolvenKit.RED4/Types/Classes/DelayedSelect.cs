using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedSelect : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<CraftingMainLogicController> Controller
		{
			get => GetPropertyValue<CWeakHandle<CraftingMainLogicController>>();
			set => SetPropertyValue<CWeakHandle<CraftingMainLogicController>>(value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CUInt32 Index
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public DelayedSelect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
