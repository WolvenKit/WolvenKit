using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmartBulletDeflectedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("localToWorld")] 
		public CMatrix LocalToWorld
		{
			get => GetPropertyValue<CMatrix>();
			set => SetPropertyValue<CMatrix>(value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public SmartBulletDeflectedEvent()
		{
			LocalToWorld = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
