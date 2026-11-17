
namespace WolvenKit.RED4.Types
{
	public partial class entTriggerComponent : entPhysicalTriggerComponent
	{
		public entTriggerComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new physicsTriggerShape();
			FilterData = new physicsFilterData();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
