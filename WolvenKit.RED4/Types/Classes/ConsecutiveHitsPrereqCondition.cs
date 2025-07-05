using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConsecutiveHitsPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("timeOut")] 
		public CFloat TimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("consecutiveHitsRequired")] 
		public CInt32 ConsecutiveHitsRequired
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("uniqueTarget")] 
		public CBool UniqueTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("consecutiveHits")] 
		public CInt32 ConsecutiveHits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("lastTargetID")] 
		public entEntityID LastTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(8)] 
		[RED("lastHitTime")] 
		public CFloat LastHitTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ConsecutiveHitsPrereqCondition()
		{
			LastTargetID = new entEntityID();
			LastHitTime = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
