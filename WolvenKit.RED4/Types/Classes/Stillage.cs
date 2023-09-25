using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Stillage : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		public Stillage()
		{
			ControllerTypeName = "StillageController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
