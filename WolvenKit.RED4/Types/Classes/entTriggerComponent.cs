
namespace WolvenKit.RED4.Types
{
	public partial class entTriggerComponent : entPhysicalTriggerComponent
	{
		public entTriggerComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new() { ShapeSize = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F }, ShapeLocalPose = new() { Position = new(), Orientation = new() { R = 1.000000F } } };
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
