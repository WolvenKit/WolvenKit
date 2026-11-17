using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_DampVector : animAnimNode_VectorValue
	{
		[Ordinal(1)] 
		[RED("defaultIncreaseSpeed")] 
		public Vector4 DefaultIncreaseSpeed
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("defaultDecreaseSpeed")] 
		public Vector4 DefaultDecreaseSpeed
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("startFromDefaultValue")] 
		public CBool StartFromDefaultValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("defaultInitialValue")] 
		public Vector4 DefaultInitialValue
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("inputNode")] 
		public animVectorLink InputNode
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(6)] 
		[RED("increaseSpeedNode")] 
		public animVectorLink IncreaseSpeedNode
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(7)] 
		[RED("decreaseSpeedNode")] 
		public animVectorLink DecreaseSpeedNode
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		public animAnimNode_DampVector()
		{
			Id = uint.MaxValue;
			DefaultIncreaseSpeed = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F };
			DefaultDecreaseSpeed = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F };
			DefaultInitialValue = new Vector4();
			InputNode = new animVectorLink();
			IncreaseSpeedNode = new animVectorLink();
			DecreaseSpeedNode = new animVectorLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
