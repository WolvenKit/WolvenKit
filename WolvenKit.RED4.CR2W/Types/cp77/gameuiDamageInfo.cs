using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageInfo : CVariable
	{
		private Vector4 _hitPosition;
		private CFloat _damageValue;
		private CEnum<gamedataDamageType> _damageType;
		private CEnum<gameuiHitType> _hitType;
		private wCHandle<gameObject> _entityHit;
		private wCHandle<gameObject> _instigator;
		private CHandle<gameuiDamageInfoUserData> _userData;

		[Ordinal(0)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get
			{
				if (_hitPosition == null)
				{
					_hitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "hitPosition", cr2w, this);
				}
				return _hitPosition;
			}
			set
			{
				if (_hitPosition == value)
				{
					return;
				}
				_hitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("damageValue")] 
		public CFloat DamageValue
		{
			get
			{
				if (_damageValue == null)
				{
					_damageValue = (CFloat) CR2WTypeManager.Create("Float", "damageValue", cr2w, this);
				}
				return _damageValue;
			}
			set
			{
				if (_damageValue == value)
				{
					return;
				}
				_damageValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get
			{
				if (_damageType == null)
				{
					_damageType = (CEnum<gamedataDamageType>) CR2WTypeManager.Create("gamedataDamageType", "damageType", cr2w, this);
				}
				return _damageType;
			}
			set
			{
				if (_damageType == value)
				{
					return;
				}
				_damageType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hitType")] 
		public CEnum<gameuiHitType> HitType
		{
			get
			{
				if (_hitType == null)
				{
					_hitType = (CEnum<gameuiHitType>) CR2WTypeManager.Create("gameuiHitType", "hitType", cr2w, this);
				}
				return _hitType;
			}
			set
			{
				if (_hitType == value)
				{
					return;
				}
				_hitType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("entityHit")] 
		public wCHandle<gameObject> EntityHit
		{
			get
			{
				if (_entityHit == null)
				{
					_entityHit = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "entityHit", cr2w, this);
				}
				return _entityHit;
			}
			set
			{
				if (_entityHit == value)
				{
					return;
				}
				_entityHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("userData")] 
		public CHandle<gameuiDamageInfoUserData> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CHandle<gameuiDamageInfoUserData>) CR2WTypeManager.Create("handle:gameuiDamageInfoUserData", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		public gameuiDamageInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
