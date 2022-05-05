using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RoadBlockTrap : InteractiveMasterDevice
	{
		[Ordinal(94)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		public RoadBlockTrap()
		{
			ControllerTypeName = "RoadBlockTrapController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
