using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponObject : gameItemObject
	{
		private rRef<gameEffectSet> _effect;
		private CBool _hasOverheat;
		private CHandle<worldEffectBlackboard> _overheatEffectBlackboard;
		private CHandle<OverheatStatListener> _overheatListener;
		private CBool _overheatDelaySent;
		private CHandle<worldEffectBlackboard> _chargeEffectBlackboard;
		private CHandle<WeaponChargeStatListener> _chargeStatListener;
		private CHandle<worldEffectBlackboard> _meleeHitEffectBlackboard;
		private CFloat _meleeHitEffectValue;
		private CHandle<DamageStatListener> _damageTypeListener;
		private CString _trailName;
		private CFloat _maxChargeThreshold;
		private CBool _lowAmmoEffectActive;
		private CHandle<gameIBlackboard> _aIBlackboard;

		[Ordinal(43)] 
		[RED("effect")] 
		public rRef<gameEffectSet> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(44)] 
		[RED("hasOverheat")] 
		public CBool HasOverheat
		{
			get => GetProperty(ref _hasOverheat);
			set => SetProperty(ref _hasOverheat, value);
		}

		[Ordinal(45)] 
		[RED("overheatEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> OverheatEffectBlackboard
		{
			get => GetProperty(ref _overheatEffectBlackboard);
			set => SetProperty(ref _overheatEffectBlackboard, value);
		}

		[Ordinal(46)] 
		[RED("overheatListener")] 
		public CHandle<OverheatStatListener> OverheatListener
		{
			get => GetProperty(ref _overheatListener);
			set => SetProperty(ref _overheatListener, value);
		}

		[Ordinal(47)] 
		[RED("overheatDelaySent")] 
		public CBool OverheatDelaySent
		{
			get => GetProperty(ref _overheatDelaySent);
			set => SetProperty(ref _overheatDelaySent, value);
		}

		[Ordinal(48)] 
		[RED("chargeEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> ChargeEffectBlackboard
		{
			get => GetProperty(ref _chargeEffectBlackboard);
			set => SetProperty(ref _chargeEffectBlackboard, value);
		}

		[Ordinal(49)] 
		[RED("chargeStatListener")] 
		public CHandle<WeaponChargeStatListener> ChargeStatListener
		{
			get => GetProperty(ref _chargeStatListener);
			set => SetProperty(ref _chargeStatListener, value);
		}

		[Ordinal(50)] 
		[RED("meleeHitEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> MeleeHitEffectBlackboard
		{
			get => GetProperty(ref _meleeHitEffectBlackboard);
			set => SetProperty(ref _meleeHitEffectBlackboard, value);
		}

		[Ordinal(51)] 
		[RED("meleeHitEffectValue")] 
		public CFloat MeleeHitEffectValue
		{
			get => GetProperty(ref _meleeHitEffectValue);
			set => SetProperty(ref _meleeHitEffectValue, value);
		}

		[Ordinal(52)] 
		[RED("damageTypeListener")] 
		public CHandle<DamageStatListener> DamageTypeListener
		{
			get => GetProperty(ref _damageTypeListener);
			set => SetProperty(ref _damageTypeListener, value);
		}

		[Ordinal(53)] 
		[RED("trailName")] 
		public CString TrailName
		{
			get => GetProperty(ref _trailName);
			set => SetProperty(ref _trailName, value);
		}

		[Ordinal(54)] 
		[RED("maxChargeThreshold")] 
		public CFloat MaxChargeThreshold
		{
			get => GetProperty(ref _maxChargeThreshold);
			set => SetProperty(ref _maxChargeThreshold, value);
		}

		[Ordinal(55)] 
		[RED("lowAmmoEffectActive")] 
		public CBool LowAmmoEffectActive
		{
			get => GetProperty(ref _lowAmmoEffectActive);
			set => SetProperty(ref _lowAmmoEffectActive, value);
		}

		[Ordinal(56)] 
		[RED("AIBlackboard")] 
		public CHandle<gameIBlackboard> AIBlackboard
		{
			get => GetProperty(ref _aIBlackboard);
			set => SetProperty(ref _aIBlackboard, value);
		}

		public gameweaponObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
