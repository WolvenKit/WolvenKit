using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_VectorWsToMs : animAnimNode_VectorValue
	{
		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<animEVectorWsToMsType> Type
		{
			get => GetPropertyValue<CEnum<animEVectorWsToMsType>>();
			set => SetPropertyValue<CEnum<animEVectorWsToMsType>>(value);
		}

		[Ordinal(2)] 
		[RED("vectorWs")] 
		public animVectorLink VectorWs
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		public animAnimNode_VectorWsToMs()
		{
			Id = uint.MaxValue;
			VectorWs = new animVectorLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
