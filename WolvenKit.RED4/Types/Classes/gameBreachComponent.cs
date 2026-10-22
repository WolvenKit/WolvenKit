using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBreachComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("healthPercentageOverride")] 
		public CFloat HealthPercentageOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameBreachComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
