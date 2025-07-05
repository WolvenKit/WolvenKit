using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExplosiveDeviceDelayedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("arrayIndex")] 
		public CInt32 ArrayIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ExplosiveDeviceDelayedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
