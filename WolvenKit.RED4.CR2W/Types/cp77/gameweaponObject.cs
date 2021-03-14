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
			get
			{
				if (_effect == null)
				{
					_effect = (rRef<gameEffectSet>) CR2WTypeManager.Create("rRef:gameEffectSet", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("hasOverheat")] 
		public CBool HasOverheat
		{
			get
			{
				if (_hasOverheat == null)
				{
					_hasOverheat = (CBool) CR2WTypeManager.Create("Bool", "hasOverheat", cr2w, this);
				}
				return _hasOverheat;
			}
			set
			{
				if (_hasOverheat == value)
				{
					return;
				}
				_hasOverheat = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("overheatEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> OverheatEffectBlackboard
		{
			get
			{
				if (_overheatEffectBlackboard == null)
				{
					_overheatEffectBlackboard = (CHandle<worldEffectBlackboard>) CR2WTypeManager.Create("handle:worldEffectBlackboard", "overheatEffectBlackboard", cr2w, this);
				}
				return _overheatEffectBlackboard;
			}
			set
			{
				if (_overheatEffectBlackboard == value)
				{
					return;
				}
				_overheatEffectBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("overheatListener")] 
		public CHandle<OverheatStatListener> OverheatListener
		{
			get
			{
				if (_overheatListener == null)
				{
					_overheatListener = (CHandle<OverheatStatListener>) CR2WTypeManager.Create("handle:OverheatStatListener", "overheatListener", cr2w, this);
				}
				return _overheatListener;
			}
			set
			{
				if (_overheatListener == value)
				{
					return;
				}
				_overheatListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("overheatDelaySent")] 
		public CBool OverheatDelaySent
		{
			get
			{
				if (_overheatDelaySent == null)
				{
					_overheatDelaySent = (CBool) CR2WTypeManager.Create("Bool", "overheatDelaySent", cr2w, this);
				}
				return _overheatDelaySent;
			}
			set
			{
				if (_overheatDelaySent == value)
				{
					return;
				}
				_overheatDelaySent = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("chargeEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> ChargeEffectBlackboard
		{
			get
			{
				if (_chargeEffectBlackboard == null)
				{
					_chargeEffectBlackboard = (CHandle<worldEffectBlackboard>) CR2WTypeManager.Create("handle:worldEffectBlackboard", "chargeEffectBlackboard", cr2w, this);
				}
				return _chargeEffectBlackboard;
			}
			set
			{
				if (_chargeEffectBlackboard == value)
				{
					return;
				}
				_chargeEffectBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("chargeStatListener")] 
		public CHandle<WeaponChargeStatListener> ChargeStatListener
		{
			get
			{
				if (_chargeStatListener == null)
				{
					_chargeStatListener = (CHandle<WeaponChargeStatListener>) CR2WTypeManager.Create("handle:WeaponChargeStatListener", "chargeStatListener", cr2w, this);
				}
				return _chargeStatListener;
			}
			set
			{
				if (_chargeStatListener == value)
				{
					return;
				}
				_chargeStatListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("meleeHitEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> MeleeHitEffectBlackboard
		{
			get
			{
				if (_meleeHitEffectBlackboard == null)
				{
					_meleeHitEffectBlackboard = (CHandle<worldEffectBlackboard>) CR2WTypeManager.Create("handle:worldEffectBlackboard", "meleeHitEffectBlackboard", cr2w, this);
				}
				return _meleeHitEffectBlackboard;
			}
			set
			{
				if (_meleeHitEffectBlackboard == value)
				{
					return;
				}
				_meleeHitEffectBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("meleeHitEffectValue")] 
		public CFloat MeleeHitEffectValue
		{
			get
			{
				if (_meleeHitEffectValue == null)
				{
					_meleeHitEffectValue = (CFloat) CR2WTypeManager.Create("Float", "meleeHitEffectValue", cr2w, this);
				}
				return _meleeHitEffectValue;
			}
			set
			{
				if (_meleeHitEffectValue == value)
				{
					return;
				}
				_meleeHitEffectValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("damageTypeListener")] 
		public CHandle<DamageStatListener> DamageTypeListener
		{
			get
			{
				if (_damageTypeListener == null)
				{
					_damageTypeListener = (CHandle<DamageStatListener>) CR2WTypeManager.Create("handle:DamageStatListener", "damageTypeListener", cr2w, this);
				}
				return _damageTypeListener;
			}
			set
			{
				if (_damageTypeListener == value)
				{
					return;
				}
				_damageTypeListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("trailName")] 
		public CString TrailName
		{
			get
			{
				if (_trailName == null)
				{
					_trailName = (CString) CR2WTypeManager.Create("String", "trailName", cr2w, this);
				}
				return _trailName;
			}
			set
			{
				if (_trailName == value)
				{
					return;
				}
				_trailName = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("maxChargeThreshold")] 
		public CFloat MaxChargeThreshold
		{
			get
			{
				if (_maxChargeThreshold == null)
				{
					_maxChargeThreshold = (CFloat) CR2WTypeManager.Create("Float", "maxChargeThreshold", cr2w, this);
				}
				return _maxChargeThreshold;
			}
			set
			{
				if (_maxChargeThreshold == value)
				{
					return;
				}
				_maxChargeThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("lowAmmoEffectActive")] 
		public CBool LowAmmoEffectActive
		{
			get
			{
				if (_lowAmmoEffectActive == null)
				{
					_lowAmmoEffectActive = (CBool) CR2WTypeManager.Create("Bool", "lowAmmoEffectActive", cr2w, this);
				}
				return _lowAmmoEffectActive;
			}
			set
			{
				if (_lowAmmoEffectActive == value)
				{
					return;
				}
				_lowAmmoEffectActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("AIBlackboard")] 
		public CHandle<gameIBlackboard> AIBlackboard
		{
			get
			{
				if (_aIBlackboard == null)
				{
					_aIBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "AIBlackboard", cr2w, this);
				}
				return _aIBlackboard;
			}
			set
			{
				if (_aIBlackboard == value)
				{
					return;
				}
				_aIBlackboard = value;
				PropertySet(this);
			}
		}

		public gameweaponObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
