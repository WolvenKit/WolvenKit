
namespace WolvenKit.RED4.Types
{
	public partial class entTriggerComponent : entPhysicalTriggerComponent
	{
		public entTriggerComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new physicsTriggerShape { ShapeSize = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F }, ShapeLocalPose = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } } };
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
