using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScaleOvershieldDecayOverTimeEffector : gameContinuousEffector
	{
		[Ordinal(0)] 
		[RED("effectApplied")] 
		public CBool EffectApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("decayModifier")] 
		public CHandle<gameStatModifierData_Deprecated> DecayModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("overshieldListener")] 
		public CHandle<OvershieldMinValueListener> OvershieldListener
		{
			get => GetPropertyValue<CHandle<OvershieldMinValueListener>>();
			set => SetPropertyValue<CHandle<OvershieldMinValueListener>>(value);
		}

		[Ordinal(4)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("elapsedTime")] 
		public CFloat ElapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("bValue")] 
		public CFloat BValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("kInitValue")] 
		public CFloat KInitValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("kValue")] 
		public CFloat KValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("maxDecay")] 
		public CFloat MaxDecay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("maxValueApplied")] 
		public CBool MaxValueApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("markedForReset")] 
		public CBool MarkedForReset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScaleOvershieldDecayOverTimeEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
