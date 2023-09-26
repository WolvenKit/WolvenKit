using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_PhysicalFractureField : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("fromHitPosition")] 
		public CBool FromHitPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("fieldParams")] 
		public physicsFractureFieldParams FieldParams
		{
			get => GetPropertyValue<physicsFractureFieldParams>();
			set => SetPropertyValue<physicsFractureFieldParams>(value);
		}

		[Ordinal(3)] 
		[RED("fieldShape")] 
		public CEnum<physicsShapeType> FieldShape
		{
			get => GetPropertyValue<CEnum<physicsShapeType>>();
			set => SetPropertyValue<CEnum<physicsShapeType>>(value);
		}

		[Ordinal(4)] 
		[RED("fieldDimensions")] 
		public Vector3 FieldDimensions
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameEffectExecutor_PhysicalFractureField()
		{
			FieldParams = new physicsFractureFieldParams { Origin = new Vector3(), FractureFieldValue = 50.000000F, FractureFieldTypeMask = Enums.physicsFractureFieldType.FF_FractureFieldGameEffect };
			FieldShape = Enums.physicsShapeType.Invalid;
			FieldDimensions = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
