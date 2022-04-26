using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_DirectionToEuler : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("inputNode")] 
		public animVectorLink InputNode
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(12)] 
		[RED("initialForwardVector")] 
		public Vector4 InitialForwardVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(13)] 
		[RED("conversionType")] 
		public CEnum<animEDirectionToEuler> ConversionType
		{
			get => GetPropertyValue<CEnum<animEDirectionToEuler>>();
			set => SetPropertyValue<CEnum<animEDirectionToEuler>>(value);
		}

		public animAnimNode_DirectionToEuler()
		{
			Id = 4294967295;
			InputNode = new();
			InitialForwardVector = new() { Y = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
