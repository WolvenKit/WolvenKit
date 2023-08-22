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
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new physicsTriggerShape { ShapeSize = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F }, ShapeLocalPose = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } } };
			IsEnabled = true;
			Impulse = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
