using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolSpentPrereqListener : BaseStatPoolPrereqListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<StatPoolSpentPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<StatPoolSpentPrereqState>>();
			set => SetPropertyValue<CWeakHandle<StatPoolSpentPrereqState>>(value);
		}

		[Ordinal(1)] 
		[RED("overallSpentValue")] 
		public CFloat OverallSpentValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public StatPoolSpentPrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
