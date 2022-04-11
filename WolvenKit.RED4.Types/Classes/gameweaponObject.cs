using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponObject : gameItemObject
	{
		[Ordinal(38)] 
		[RED("effect")] 
		public CResourceReference<gameEffectSet> Effect
		{
			get => GetPropertyValue<CResourceReference<gameEffectSet>>();
			set => SetPropertyValue<CResourceReference<gameEffectSet>>(value);
		}

		[Ordinal(39)] 
		[RED("hasOverheat")] 
		public CBool HasOverheat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("overheatEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> OverheatEffectBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(41)] 
		[RED("overheatListener")] 
		public CHandle<OverheatStatListener> OverheatListener
		{
			get => GetPropertyValue<CHandle<OverheatStatListener>>();
			set => SetPropertyValue<CHandle<OverheatStatListener>>(value);
		}

		[Ordinal(42)] 
		[RED("overheatDelaySent")] 
		public CBool OverheatDelaySent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("chargeEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> ChargeEffectBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(44)] 
		[RED("chargeStatListener")] 
		public CHandle<WeaponChargeStatListener> ChargeStatListener
		{
			get => GetPropertyValue<CHandle<WeaponChargeStatListener>>();
			set => SetPropertyValue<CHandle<WeaponChargeStatListener>>(value);
		}

		[Ordinal(45)] 
		[RED("triggerEffectName")] 
		public CName TriggerEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(46)] 
		[RED("meleeHitEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> MeleeHitEffectBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(47)] 
		[RED("meleeHitEffectValue")] 
		public CFloat MeleeHitEffectValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("damageTypeListener")] 
		public CHandle<DamageStatListener> DamageTypeListener
		{
			get => GetPropertyValue<CHandle<DamageStatListener>>();
			set => SetPropertyValue<CHandle<DamageStatListener>>(value);
		}

		[Ordinal(49)] 
		[RED("trailName")] 
		public CString TrailName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(50)] 
		[RED("maxChargeThreshold")] 
		public CFloat MaxChargeThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("animOwner")] 
		public CInt32 AnimOwner
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(52)] 
		[RED("lowAmmoEffectActive")] 
		public CBool LowAmmoEffectActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("hasSecondaryTriggerMode")] 
		public CBool HasSecondaryTriggerMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetPropertyValue<CHandle<gamedataWeaponItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataWeaponItem_Record>>(value);
		}

		[Ordinal(55)] 
		[RED("isHeavyWeapon")] 
		public CBool IsHeavyWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("isMeleeWeapon")] 
		public CBool IsMeleeWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("isRangedWeapon")] 
		public CBool IsRangedWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("AIBlackboard")] 
		public CHandle<gameIBlackboard> AIBlackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		public gameweaponObject()
		{
			MaxChargeThreshold = 100.000000F;
		}
	}
}
