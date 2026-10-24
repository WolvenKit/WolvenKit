using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entPhysicalImpulseAreaComponent : entPhysicalTriggerComponent
	{
		[Ordinal(9)] 
		[RED("impulse")] 
		public Vector3 Impulse
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(10)] 
		[RED("impulseRadius")] 
		public CFloat ImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entPhysicalImpulseAreaComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new physicsTriggerShape();
			FilterData = new physicsFilterData();
			IsEnabled = true;
			Impulse = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
