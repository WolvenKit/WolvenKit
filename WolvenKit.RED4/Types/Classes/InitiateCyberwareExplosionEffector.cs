using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InitiateCyberwareExplosionEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("maxRangeAddition")] 
		public CFloat MaxRangeAddition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("attackRecord")] 
		public CWeakHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAttack_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAttack_Record>>(value);
		}

		public InitiateCyberwareExplosionEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
