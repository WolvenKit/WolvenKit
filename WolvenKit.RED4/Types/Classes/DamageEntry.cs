using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DamageEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("damageInfo")] 
		public gameuiDamageInfo DamageInfo
		{
			get => GetPropertyValue<gameuiDamageInfo>();
			set => SetPropertyValue<gameuiDamageInfo>(value);
		}

		[Ordinal(1)] 
		[RED("damageOverTimeInfo")] 
		public gameuiDamageInfo DamageOverTimeInfo
		{
			get => GetPropertyValue<gameuiDamageInfo>();
			set => SetPropertyValue<gameuiDamageInfo>(value);
		}

		[Ordinal(2)] 
		[RED("hasDamageInfo")] 
		public CBool HasDamageInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("hasDamageOverTimeInfo")] 
		public CBool HasDamageOverTimeInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("oneInstance")] 
		public CBool OneInstance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("oneDotInstance")] 
		public CBool OneDotInstance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("hasDotAccumulator")] 
		public CBool HasDotAccumulator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DamageEntry()
		{
			DamageInfo = new gameuiDamageInfo { HitPosition = new Vector4(), DamageType = Enums.gamedataDamageType.Invalid };
			DamageOverTimeInfo = new gameuiDamageInfo { HitPosition = new Vector4(), DamageType = Enums.gamedataDamageType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
