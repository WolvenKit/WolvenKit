using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleGridDestructionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state", 16)] 
		public CArrayFixedSize<CFloat> State
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("rawChange", 16)] 
		public CArrayFixedSize<CFloat> RawChange
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("desiredChange", 16)] 
		public CArrayFixedSize<CFloat> DesiredChange
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("damageMultiplier")] 
		public CFloat DamageMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("impactPoint")] 
		public Vector3 ImpactPoint
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("otherVehicle")] 
		public CWeakHandle<gameObject> OtherVehicle
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(6)] 
		[RED("rammedOtherVehicle")] 
		public CBool RammedOtherVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("otherVehicleRammed")] 
		public CBool OtherVehicleRammed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleGridDestructionEvent()
		{
			State = new(16);
			RawChange = new(16);
			DesiredChange = new(16);
			ImpactPoint = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
