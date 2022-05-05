using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_VectorWsToMs : animAnimNode_VectorValue
	{
		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<animEVectorWsToMsType> Type
		{
			get => GetPropertyValue<CEnum<animEVectorWsToMsType>>();
			set => SetPropertyValue<CEnum<animEVectorWsToMsType>>(value);
		}

		[Ordinal(12)] 
		[RED("vectorWs")] 
		public animVectorLink VectorWs
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		public animAnimNode_VectorWsToMs()
		{
			Id = 4294967295;
			VectorWs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
