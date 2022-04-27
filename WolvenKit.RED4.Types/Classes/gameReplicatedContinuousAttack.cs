using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameReplicatedContinuousAttack : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startTimeStamp")] 
		public netTime StartTimeStamp
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(1)] 
		[RED("stopTimeStamp")] 
		public netTime StopTimeStamp
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(2)] 
		[RED("attackId")] 
		public TweakDBID AttackId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameReplicatedContinuousAttack()
		{
			StartTimeStamp = new() { MilliSecs = 18446744073709551615 };
			StopTimeStamp = new() { MilliSecs = 18446744073709551615 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
