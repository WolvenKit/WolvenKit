using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WallScreen : TV
	{
		[Ordinal(101)] 
		[RED("movementPattern")] 
		public SMovementPattern MovementPattern
		{
			get => GetPropertyValue<SMovementPattern>();
			set => SetPropertyValue<SMovementPattern>(value);
		}

		[Ordinal(102)] 
		[RED("factOnFullyOpened")] 
		public CName FactOnFullyOpened
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(103)] 
		[RED("objectMover")] 
		public CHandle<ObjectMoverComponent> ObjectMover
		{
			get => GetPropertyValue<CHandle<ObjectMoverComponent>>();
			set => SetPropertyValue<CHandle<ObjectMoverComponent>>(value);
		}

		public WallScreen()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
