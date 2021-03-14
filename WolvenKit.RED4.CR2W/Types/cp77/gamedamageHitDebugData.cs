using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedamageHitDebugData : IScriptable
	{
		private Vector4 _sourceHitPosition;
		private Vector4 _targetHitPosition;
		private wCHandle<gameObject> _instigator;
		private wCHandle<gameObject> _source;
		private wCHandle<gameObject> _target;
		private CName _instigatorName;
		private CName _sourceName;
		private CName _targetName;
		private gameAttackDebugData _sourceAttackDebugData;
		private CName _sourceWeaponName;
		private CName _sourceAttackName;
		private CArray<CHandle<gamedamageDamageDebugData>> _calculatedDamages;
		private CArray<CHandle<gamedamageDamageDebugData>> _appliedDamages;
		private CName _hitType;
		private CName _hitFlags;

		[Ordinal(0)] 
		[RED("sourceHitPosition")] 
		public Vector4 SourceHitPosition
		{
			get
			{
				if (_sourceHitPosition == null)
				{
					_sourceHitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "sourceHitPosition", cr2w, this);
				}
				return _sourceHitPosition;
			}
			set
			{
				if (_sourceHitPosition == value)
				{
					return;
				}
				_sourceHitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetHitPosition")] 
		public Vector4 TargetHitPosition
		{
			get
			{
				if (_targetHitPosition == null)
				{
					_targetHitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "targetHitPosition", cr2w, this);
				}
				return _targetHitPosition;
			}
			set
			{
				if (_targetHitPosition == value)
				{
					return;
				}
				_targetHitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("instigatorName")] 
		public CName InstigatorName
		{
			get
			{
				if (_instigatorName == null)
				{
					_instigatorName = (CName) CR2WTypeManager.Create("CName", "instigatorName", cr2w, this);
				}
				return _instigatorName;
			}
			set
			{
				if (_instigatorName == value)
				{
					return;
				}
				_instigatorName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get
			{
				if (_sourceName == null)
				{
					_sourceName = (CName) CR2WTypeManager.Create("CName", "sourceName", cr2w, this);
				}
				return _sourceName;
			}
			set
			{
				if (_sourceName == value)
				{
					return;
				}
				_sourceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get
			{
				if (_targetName == null)
				{
					_targetName = (CName) CR2WTypeManager.Create("CName", "targetName", cr2w, this);
				}
				return _targetName;
			}
			set
			{
				if (_targetName == value)
				{
					return;
				}
				_targetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("sourceAttackDebugData")] 
		public gameAttackDebugData SourceAttackDebugData
		{
			get
			{
				if (_sourceAttackDebugData == null)
				{
					_sourceAttackDebugData = (gameAttackDebugData) CR2WTypeManager.Create("gameAttackDebugData", "sourceAttackDebugData", cr2w, this);
				}
				return _sourceAttackDebugData;
			}
			set
			{
				if (_sourceAttackDebugData == value)
				{
					return;
				}
				_sourceAttackDebugData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("sourceWeaponName")] 
		public CName SourceWeaponName
		{
			get
			{
				if (_sourceWeaponName == null)
				{
					_sourceWeaponName = (CName) CR2WTypeManager.Create("CName", "sourceWeaponName", cr2w, this);
				}
				return _sourceWeaponName;
			}
			set
			{
				if (_sourceWeaponName == value)
				{
					return;
				}
				_sourceWeaponName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("sourceAttackName")] 
		public CName SourceAttackName
		{
			get
			{
				if (_sourceAttackName == null)
				{
					_sourceAttackName = (CName) CR2WTypeManager.Create("CName", "sourceAttackName", cr2w, this);
				}
				return _sourceAttackName;
			}
			set
			{
				if (_sourceAttackName == value)
				{
					return;
				}
				_sourceAttackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("calculatedDamages")] 
		public CArray<CHandle<gamedamageDamageDebugData>> CalculatedDamages
		{
			get
			{
				if (_calculatedDamages == null)
				{
					_calculatedDamages = (CArray<CHandle<gamedamageDamageDebugData>>) CR2WTypeManager.Create("array:handle:gamedamageDamageDebugData", "calculatedDamages", cr2w, this);
				}
				return _calculatedDamages;
			}
			set
			{
				if (_calculatedDamages == value)
				{
					return;
				}
				_calculatedDamages = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("appliedDamages")] 
		public CArray<CHandle<gamedamageDamageDebugData>> AppliedDamages
		{
			get
			{
				if (_appliedDamages == null)
				{
					_appliedDamages = (CArray<CHandle<gamedamageDamageDebugData>>) CR2WTypeManager.Create("array:handle:gamedamageDamageDebugData", "appliedDamages", cr2w, this);
				}
				return _appliedDamages;
			}
			set
			{
				if (_appliedDamages == value)
				{
					return;
				}
				_appliedDamages = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("hitType")] 
		public CName HitType
		{
			get
			{
				if (_hitType == null)
				{
					_hitType = (CName) CR2WTypeManager.Create("CName", "hitType", cr2w, this);
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

		[Ordinal(14)] 
		[RED("hitFlags")] 
		public CName HitFlags
		{
			get
			{
				if (_hitFlags == null)
				{
					_hitFlags = (CName) CR2WTypeManager.Create("CName", "hitFlags", cr2w, this);
				}
				return _hitFlags;
			}
			set
			{
				if (_hitFlags == value)
				{
					return;
				}
				_hitFlags = value;
				PropertySet(this);
			}
		}

		public gamedamageHitDebugData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
