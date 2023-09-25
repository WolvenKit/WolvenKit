using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HoloFeeder : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("feederMesh")] 
		public CHandle<entIPlacedComponent> FeederMesh
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("feederMesh1")] 
		public CHandle<entIPlacedComponent> FeederMesh1
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		public HoloFeeder()
		{
			ControllerTypeName = "HoloFeederController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
