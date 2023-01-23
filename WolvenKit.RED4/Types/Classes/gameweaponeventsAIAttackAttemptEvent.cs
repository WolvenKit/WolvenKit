using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponeventsAIAttackAttemptEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("isWindUp")] 
		public CBool IsWindUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("continuousMode")] 
		public CEnum<gameEContinuousMode> ContinuousMode
		{
			get => GetPropertyValue<CEnum<gameEContinuousMode>>();
			set => SetPropertyValue<CEnum<gameEContinuousMode>>(value);
		}

		[Ordinal(4)] 
		[RED("minimumOpacity")] 
		public CFloat MinimumOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameweaponeventsAIAttackAttemptEvent()
		{
			MinimumOpacity = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
