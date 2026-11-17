using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPhysicalFractureFieldNode : worldNode
	{
		[Ordinal(2)] 
		[RED("shape")] 
		public physicsTriggerShape Shape
		{
			get => GetPropertyValue<physicsTriggerShape>();
			set => SetPropertyValue<physicsTriggerShape>(value);
		}

		[Ordinal(3)] 
		[RED("fractureFieldParams")] 
		public physicsFractureFieldParams FractureFieldParams
		{
			get => GetPropertyValue<physicsFractureFieldParams>();
			set => SetPropertyValue<physicsFractureFieldParams>(value);
		}

		public worldPhysicalFractureFieldNode()
		{
			Shape = new physicsTriggerShape();
			FractureFieldParams = new physicsFractureFieldParams { FractureFieldValue = 50.000000F, FractureFieldTypeMask = Enums.physicsFractureFieldType.FF_FractureFieldNode };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
