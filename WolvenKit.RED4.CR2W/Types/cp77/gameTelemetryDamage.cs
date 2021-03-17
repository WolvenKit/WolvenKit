using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryDamage : CVariable
	{
		private CEnum<gamedataAttackType> _attackType;
		private CFloat _damageAmount;
		private gameTelemetryInventoryItem _weapon;
		private CUInt32 _hitCount;
		private CFloat _distance;
		private CFloat _time;

		[Ordinal(0)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(1)] 
		[RED("damageAmount")] 
		public CFloat DamageAmount
		{
			get => GetProperty(ref _damageAmount);
			set => SetProperty(ref _damageAmount, value);
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public gameTelemetryInventoryItem Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(3)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get => GetProperty(ref _hitCount);
			set => SetProperty(ref _hitCount, value);
		}

		[Ordinal(4)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(5)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		public gameTelemetryDamage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
