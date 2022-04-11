using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_CoordinateFromVector : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("vectorCoodrinateType")] 
		public CEnum<animVectorCoordinateType> VectorCoodrinateType
		{
			get => GetPropertyValue<CEnum<animVectorCoordinateType>>();
			set => SetPropertyValue<CEnum<animVectorCoordinateType>>(value);
		}

		[Ordinal(12)] 
		[RED("input")] 
		public animVectorLink Input
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		public animAnimNode_CoordinateFromVector()
		{
			Id = 4294967295;
			Input = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
