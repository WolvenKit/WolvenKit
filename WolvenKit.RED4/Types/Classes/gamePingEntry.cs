using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePingEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("time")] 
		public netTime Time
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(3)] 
		[RED("pingType")] 
		public CEnum<gamedataPingType> PingType
		{
			get => GetPropertyValue<CEnum<gamedataPingType>>();
			set => SetPropertyValue<CEnum<gamedataPingType>>(value);
		}

		[Ordinal(4)] 
		[RED("hitObject")] 
		public CWeakHandle<entEntity> HitObject
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public gamePingEntry()
		{
			WorldPosition = new();
			Time = new();
			PingType = Enums.gamedataPingType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
