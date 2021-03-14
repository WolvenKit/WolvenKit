using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLightComponent : entLightComponent
	{
		private CBool _emissiveOnly;
		private CEnum<gameEMaterialZone> _materialZone;
		private CName _meshBrokenAppearance;
		private CFloat _onStrength;
		private CBool _turnOnByDefault;
		private CFloat _turnOnTime;
		private CName _turnOnCurve;
		private CFloat _turnOffTime;
		private CName _turnOffCurve;
		private CFloat _loopTime;
		private CName _loopCurve;
		private CBool _isDestructible;
		private CName _colliderName;
		private CName _colliderTag;
		private raRef<worldEffect> _destructionEffect;

		[Ordinal(54)] 
		[RED("emissiveOnly")] 
		public CBool EmissiveOnly
		{
			get
			{
				if (_emissiveOnly == null)
				{
					_emissiveOnly = (CBool) CR2WTypeManager.Create("Bool", "emissiveOnly", cr2w, this);
				}
				return _emissiveOnly;
			}
			set
			{
				if (_emissiveOnly == value)
				{
					return;
				}
				_emissiveOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("materialZone")] 
		public CEnum<gameEMaterialZone> MaterialZone
		{
			get
			{
				if (_materialZone == null)
				{
					_materialZone = (CEnum<gameEMaterialZone>) CR2WTypeManager.Create("gameEMaterialZone", "materialZone", cr2w, this);
				}
				return _materialZone;
			}
			set
			{
				if (_materialZone == value)
				{
					return;
				}
				_materialZone = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("meshBrokenAppearance")] 
		public CName MeshBrokenAppearance
		{
			get
			{
				if (_meshBrokenAppearance == null)
				{
					_meshBrokenAppearance = (CName) CR2WTypeManager.Create("CName", "meshBrokenAppearance", cr2w, this);
				}
				return _meshBrokenAppearance;
			}
			set
			{
				if (_meshBrokenAppearance == value)
				{
					return;
				}
				_meshBrokenAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("onStrength")] 
		public CFloat OnStrength
		{
			get
			{
				if (_onStrength == null)
				{
					_onStrength = (CFloat) CR2WTypeManager.Create("Float", "onStrength", cr2w, this);
				}
				return _onStrength;
			}
			set
			{
				if (_onStrength == value)
				{
					return;
				}
				_onStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("turnOnByDefault")] 
		public CBool TurnOnByDefault
		{
			get
			{
				if (_turnOnByDefault == null)
				{
					_turnOnByDefault = (CBool) CR2WTypeManager.Create("Bool", "turnOnByDefault", cr2w, this);
				}
				return _turnOnByDefault;
			}
			set
			{
				if (_turnOnByDefault == value)
				{
					return;
				}
				_turnOnByDefault = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("turnOnTime")] 
		public CFloat TurnOnTime
		{
			get
			{
				if (_turnOnTime == null)
				{
					_turnOnTime = (CFloat) CR2WTypeManager.Create("Float", "turnOnTime", cr2w, this);
				}
				return _turnOnTime;
			}
			set
			{
				if (_turnOnTime == value)
				{
					return;
				}
				_turnOnTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("turnOnCurve")] 
		public CName TurnOnCurve
		{
			get
			{
				if (_turnOnCurve == null)
				{
					_turnOnCurve = (CName) CR2WTypeManager.Create("CName", "turnOnCurve", cr2w, this);
				}
				return _turnOnCurve;
			}
			set
			{
				if (_turnOnCurve == value)
				{
					return;
				}
				_turnOnCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("turnOffTime")] 
		public CFloat TurnOffTime
		{
			get
			{
				if (_turnOffTime == null)
				{
					_turnOffTime = (CFloat) CR2WTypeManager.Create("Float", "turnOffTime", cr2w, this);
				}
				return _turnOffTime;
			}
			set
			{
				if (_turnOffTime == value)
				{
					return;
				}
				_turnOffTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("turnOffCurve")] 
		public CName TurnOffCurve
		{
			get
			{
				if (_turnOffCurve == null)
				{
					_turnOffCurve = (CName) CR2WTypeManager.Create("CName", "turnOffCurve", cr2w, this);
				}
				return _turnOffCurve;
			}
			set
			{
				if (_turnOffCurve == value)
				{
					return;
				}
				_turnOffCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("loopTime")] 
		public CFloat LoopTime
		{
			get
			{
				if (_loopTime == null)
				{
					_loopTime = (CFloat) CR2WTypeManager.Create("Float", "loopTime", cr2w, this);
				}
				return _loopTime;
			}
			set
			{
				if (_loopTime == value)
				{
					return;
				}
				_loopTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("loopCurve")] 
		public CName LoopCurve
		{
			get
			{
				if (_loopCurve == null)
				{
					_loopCurve = (CName) CR2WTypeManager.Create("CName", "loopCurve", cr2w, this);
				}
				return _loopCurve;
			}
			set
			{
				if (_loopCurve == value)
				{
					return;
				}
				_loopCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get
			{
				if (_isDestructible == null)
				{
					_isDestructible = (CBool) CR2WTypeManager.Create("Bool", "isDestructible", cr2w, this);
				}
				return _isDestructible;
			}
			set
			{
				if (_isDestructible == value)
				{
					return;
				}
				_isDestructible = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("colliderName")] 
		public CName ColliderName
		{
			get
			{
				if (_colliderName == null)
				{
					_colliderName = (CName) CR2WTypeManager.Create("CName", "colliderName", cr2w, this);
				}
				return _colliderName;
			}
			set
			{
				if (_colliderName == value)
				{
					return;
				}
				_colliderName = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("colliderTag")] 
		public CName ColliderTag
		{
			get
			{
				if (_colliderTag == null)
				{
					_colliderTag = (CName) CR2WTypeManager.Create("CName", "colliderTag", cr2w, this);
				}
				return _colliderTag;
			}
			set
			{
				if (_colliderTag == value)
				{
					return;
				}
				_colliderTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("destructionEffect")] 
		public raRef<worldEffect> DestructionEffect
		{
			get
			{
				if (_destructionEffect == null)
				{
					_destructionEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "destructionEffect", cr2w, this);
				}
				return _destructionEffect;
			}
			set
			{
				if (_destructionEffect == value)
				{
					return;
				}
				_destructionEffect = value;
				PropertySet(this);
			}
		}

		public gameLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
