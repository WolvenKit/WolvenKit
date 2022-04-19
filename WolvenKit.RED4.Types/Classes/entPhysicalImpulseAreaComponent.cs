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
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new() { ShapeSize = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F }, ShapeLocalPose = new() { Position = new(), Orientation = new() { R = 1.000000F } } };
			IsEnabled = true;
			Impulse = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
