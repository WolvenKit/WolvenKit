using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entPhysicalFractureFieldComponent : entPhysicalTriggerComponent
	{
		[Ordinal(9)] 
		[RED("fractureFieldParams")] 
		public physicsFractureFieldParams FractureFieldParams
		{
			get => GetPropertyValue<physicsFractureFieldParams>();
			set => SetPropertyValue<physicsFractureFieldParams>(value);
		}

		public entPhysicalFractureFieldComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new physicsTriggerShape { ShapeSize = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F }, ShapeLocalPose = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } } };
			IsEnabled = true;
			FractureFieldParams = new physicsFractureFieldParams { Origin = new Vector3(), FractureFieldValue = 50.000000F, FractureFieldTypeMask = Enums.physicsFractureFieldType.FF_FractureFieldComponent };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
