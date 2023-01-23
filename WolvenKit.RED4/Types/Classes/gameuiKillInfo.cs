using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiKillInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("killerEntity")] 
		public CWeakHandle<gameObject> KillerEntity
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("victimEntity")] 
		public CWeakHandle<gameObject> VictimEntity
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get => GetPropertyValue<CEnum<gameKillType>>();
			set => SetPropertyValue<CEnum<gameKillType>>(value);
		}

		public gameuiKillInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
