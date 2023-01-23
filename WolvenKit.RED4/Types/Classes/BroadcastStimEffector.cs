using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BroadcastStimEffector : gameContinuousEffector
	{
		[Ordinal(0)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public BroadcastStimEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
