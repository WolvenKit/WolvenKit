using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITimeoutCondition : AITimeCondition
	{
		[Ordinal(0)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AITimeoutCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
