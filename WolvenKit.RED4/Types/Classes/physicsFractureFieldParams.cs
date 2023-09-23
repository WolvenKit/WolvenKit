using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsFractureFieldParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("origin")] 
		public Vector3 Origin
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("fractureFieldValue")] 
		public CFloat FractureFieldValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("destructionTypeMask")] 
		public CBitField<physicsDestructionType> DestructionTypeMask
		{
			get => GetPropertyValue<CBitField<physicsDestructionType>>();
			set => SetPropertyValue<CBitField<physicsDestructionType>>(value);
		}

		[Ordinal(3)] 
		[RED("fractureFieldTypeMask")] 
		public CBitField<physicsFractureFieldType> FractureFieldTypeMask
		{
			get => GetPropertyValue<CBitField<physicsFractureFieldType>>();
			set => SetPropertyValue<CBitField<physicsFractureFieldType>>(value);
		}

		[Ordinal(4)] 
		[RED("fractureFieldOptionsMask")] 
		public CBitField<physicsFractureFieldOptions> FractureFieldOptionsMask
		{
			get => GetPropertyValue<CBitField<physicsFractureFieldOptions>>();
			set => SetPropertyValue<CBitField<physicsFractureFieldOptions>>(value);
		}

		[Ordinal(5)] 
		[RED("fractureFieldEffect")] 
		public CEnum<physicsFractureFieldEffect> FractureFieldEffect
		{
			get => GetPropertyValue<CEnum<physicsFractureFieldEffect>>();
			set => SetPropertyValue<CEnum<physicsFractureFieldEffect>>(value);
		}

		[Ordinal(6)] 
		[RED("fractureFieldValueType")] 
		public CEnum<physicsFractureFieldValueType> FractureFieldValueType
		{
			get => GetPropertyValue<CEnum<physicsFractureFieldValueType>>();
			set => SetPropertyValue<CEnum<physicsFractureFieldValueType>>(value);
		}

		public physicsFractureFieldParams()
		{
			Origin = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
