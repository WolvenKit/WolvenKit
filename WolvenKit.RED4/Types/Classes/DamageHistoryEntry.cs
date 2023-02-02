using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DamageHistoryEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetPropertyValue<CHandle<gameeventsHitEvent>>();
			set => SetPropertyValue<CHandle<gameeventsHitEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("totalDamageReceived")] 
		public CFloat TotalDamageReceived
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("frameReceived")] 
		public CUInt64 FrameReceived
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("healthAtTheTime")] 
		public CFloat HealthAtTheTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(6)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public DamageHistoryEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
