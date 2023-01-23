using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GetTargetLastKnownPosition : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("inTargetObject")] 
		public CHandle<AIArgumentMapping> InTargetObject
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("outPosition")] 
		public CHandle<AIArgumentMapping> OutPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("predictionTime")] 
		public CFloat PredictionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public GetTargetLastKnownPosition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
