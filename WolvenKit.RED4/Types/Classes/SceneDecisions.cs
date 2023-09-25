using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SceneDecisions : VehicleTransition
	{
		[Ordinal(2)] 
		[RED("sceneTierCallback")] 
		public CHandle<redCallbackObject> SceneTierCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public SceneDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
