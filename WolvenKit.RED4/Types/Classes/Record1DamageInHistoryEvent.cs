using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Record1DamageInHistoryEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public Record1DamageInHistoryEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
