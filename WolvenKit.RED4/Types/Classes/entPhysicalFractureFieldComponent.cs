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
			LocalTransform = new WorldTransform();
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new physicsTriggerShape();
			FilterData = new physicsFilterData();
			IsEnabled = true;
			FractureFieldParams = new physicsFractureFieldParams { FractureFieldValue = 50.000000F, FractureFieldTypeMask = Enums.physicsFractureFieldType.FF_FractureFieldComponent };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
