using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectSharedDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _attackStatModList;
		private gamebbScriptID_Vector4 _box;
		private gamebbScriptID_Float _charge;
		private gamebbScriptID_Float _duration;
		private gamebbScriptID_Float _hitCooldown;
		private gamebbScriptID_String _effectName;
		private gamebbScriptID_EntityPtr _entity;
		private gamebbScriptID_Vector4 _forward;
		private gamebbScriptID_Variant _fxPackage;
		private gamebbScriptID_Variant _attackData;
		private gamebbScriptID_Bool _infiniteDuration;
		private gamebbScriptID_Bool _playerOwnedWeapon;
		private gamebbScriptID_Vector4 _position;
		private gamebbScriptID_Vector4 _muzzlePosition;
		private gamebbScriptID_Variant _projectileHitEvent;
		private gamebbScriptID_Float _radius;
		private gamebbScriptID_Float _range;
		private gamebbScriptID_Bool _renderMaterialOverride;
		private gamebbScriptID_Quaternion _rotation;
		private gamebbScriptID_Float _minRayAngleDiff;
		private gamebbScriptID_Int32 _statType;
		private gamebbScriptID_Variant _stimuliEvent;
		private gamebbScriptID_Bool _stimuliRaycastTest;
		private gamebbScriptID_Bool _stimuliNavigationTest;
		private gamebbScriptID_Bool _stimuliConeFilter;
		private gamebbScriptID_Bool _stimuliAxisFilter;
		private gamebbScriptID_Vector4 _stimuliAxisConstraints;
		private gamebbScriptID_Int32 _stimType;
		private gamebbScriptID_Float _value;
		private gamebbScriptID_Variant _flags;
		private gamebbScriptID_Variant _attack;
		private gamebbScriptID_Variant _attackId;
		private gamebbScriptID_Int32 _attackNumber;
		private gamebbScriptID_CName _impactOrientationSlot;
		private gamebbScriptID_Variant _statusEffect;
		private gamebbScriptID_Float _angle;
		private gamebbScriptID_Bool _fallback_weaponPierce;
		private gamebbScriptID_Float _fallback_weaponPierceChargeLevel;
		private gamebbScriptID_Vector4 _raycastEnd;
		private gamebbScriptID_Float _maxPathLength;
		private gamebbScriptID_String _effectorRecordName;
		private gamebbScriptID_Variant _targets;
		private gamebbScriptID_Int32 _highlightType;
		private gamebbScriptID_Int32 _outlineType;
		private gamebbScriptID_Int32 _highlightPriority;
		private gamebbScriptID_Variant _fxResource;
		private gamebbScriptID_Float _dotCycleDuration;
		private gamebbScriptID_Float _dotLastApplicationTime;
		private gamebbScriptID_Bool _enable;
		private gamebbScriptID_CName _slotName;
		private gamebbScriptID_Variant _targetComponent;
		private gamebbScriptID_Bool _meleeCleave;
		private gamebbScriptID_Variant _highlightedTargets;
		private gamebbScriptID_Variant _forceVisionAppearanceData;
		private gamebbScriptID_Bool _debugBool;

		[Ordinal(0)] 
		[RED("attackStatModList")] 
		public gamebbScriptID_Variant AttackStatModList
		{
			get
			{
				if (_attackStatModList == null)
				{
					_attackStatModList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "attackStatModList", cr2w, this);
				}
				return _attackStatModList;
			}
			set
			{
				if (_attackStatModList == value)
				{
					return;
				}
				_attackStatModList = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("box")] 
		public gamebbScriptID_Vector4 Box
		{
			get
			{
				if (_box == null)
				{
					_box = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "box", cr2w, this);
				}
				return _box;
			}
			set
			{
				if (_box == value)
				{
					return;
				}
				_box = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("charge")] 
		public gamebbScriptID_Float Charge
		{
			get
			{
				if (_charge == null)
				{
					_charge = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "charge", cr2w, this);
				}
				return _charge;
			}
			set
			{
				if (_charge == value)
				{
					return;
				}
				_charge = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public gamebbScriptID_Float Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hitCooldown")] 
		public gamebbScriptID_Float HitCooldown
		{
			get
			{
				if (_hitCooldown == null)
				{
					_hitCooldown = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "hitCooldown", cr2w, this);
				}
				return _hitCooldown;
			}
			set
			{
				if (_hitCooldown == value)
				{
					return;
				}
				_hitCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("effectName")] 
		public gamebbScriptID_String EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("entity")] 
		public gamebbScriptID_EntityPtr Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (gamebbScriptID_EntityPtr) CR2WTypeManager.Create("gamebbScriptID_EntityPtr", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("forward")] 
		public gamebbScriptID_Vector4 Forward
		{
			get
			{
				if (_forward == null)
				{
					_forward = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "forward", cr2w, this);
				}
				return _forward;
			}
			set
			{
				if (_forward == value)
				{
					return;
				}
				_forward = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fxPackage")] 
		public gamebbScriptID_Variant FxPackage
		{
			get
			{
				if (_fxPackage == null)
				{
					_fxPackage = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "fxPackage", cr2w, this);
				}
				return _fxPackage;
			}
			set
			{
				if (_fxPackage == value)
				{
					return;
				}
				_fxPackage = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("attackData")] 
		public gamebbScriptID_Variant AttackData
		{
			get
			{
				if (_attackData == null)
				{
					_attackData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "attackData", cr2w, this);
				}
				return _attackData;
			}
			set
			{
				if (_attackData == value)
				{
					return;
				}
				_attackData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("infiniteDuration")] 
		public gamebbScriptID_Bool InfiniteDuration
		{
			get
			{
				if (_infiniteDuration == null)
				{
					_infiniteDuration = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "infiniteDuration", cr2w, this);
				}
				return _infiniteDuration;
			}
			set
			{
				if (_infiniteDuration == value)
				{
					return;
				}
				_infiniteDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("playerOwnedWeapon")] 
		public gamebbScriptID_Bool PlayerOwnedWeapon
		{
			get
			{
				if (_playerOwnedWeapon == null)
				{
					_playerOwnedWeapon = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "playerOwnedWeapon", cr2w, this);
				}
				return _playerOwnedWeapon;
			}
			set
			{
				if (_playerOwnedWeapon == value)
				{
					return;
				}
				_playerOwnedWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("position")] 
		public gamebbScriptID_Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("muzzlePosition")] 
		public gamebbScriptID_Vector4 MuzzlePosition
		{
			get
			{
				if (_muzzlePosition == null)
				{
					_muzzlePosition = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "muzzlePosition", cr2w, this);
				}
				return _muzzlePosition;
			}
			set
			{
				if (_muzzlePosition == value)
				{
					return;
				}
				_muzzlePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("projectileHitEvent")] 
		public gamebbScriptID_Variant ProjectileHitEvent
		{
			get
			{
				if (_projectileHitEvent == null)
				{
					_projectileHitEvent = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "projectileHitEvent", cr2w, this);
				}
				return _projectileHitEvent;
			}
			set
			{
				if (_projectileHitEvent == value)
				{
					return;
				}
				_projectileHitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("radius")] 
		public gamebbScriptID_Float Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("range")] 
		public gamebbScriptID_Float Range
		{
			get
			{
				if (_range == null)
				{
					_range = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("renderMaterialOverride")] 
		public gamebbScriptID_Bool RenderMaterialOverride
		{
			get
			{
				if (_renderMaterialOverride == null)
				{
					_renderMaterialOverride = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "renderMaterialOverride", cr2w, this);
				}
				return _renderMaterialOverride;
			}
			set
			{
				if (_renderMaterialOverride == value)
				{
					return;
				}
				_renderMaterialOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("rotation")] 
		public gamebbScriptID_Quaternion Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (gamebbScriptID_Quaternion) CR2WTypeManager.Create("gamebbScriptID_Quaternion", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("minRayAngleDiff")] 
		public gamebbScriptID_Float MinRayAngleDiff
		{
			get
			{
				if (_minRayAngleDiff == null)
				{
					_minRayAngleDiff = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "minRayAngleDiff", cr2w, this);
				}
				return _minRayAngleDiff;
			}
			set
			{
				if (_minRayAngleDiff == value)
				{
					return;
				}
				_minRayAngleDiff = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("statType")] 
		public gamebbScriptID_Int32 StatType
		{
			get
			{
				if (_statType == null)
				{
					_statType = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "statType", cr2w, this);
				}
				return _statType;
			}
			set
			{
				if (_statType == value)
				{
					return;
				}
				_statType = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("stimuliEvent")] 
		public gamebbScriptID_Variant StimuliEvent
		{
			get
			{
				if (_stimuliEvent == null)
				{
					_stimuliEvent = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "stimuliEvent", cr2w, this);
				}
				return _stimuliEvent;
			}
			set
			{
				if (_stimuliEvent == value)
				{
					return;
				}
				_stimuliEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("stimuliRaycastTest")] 
		public gamebbScriptID_Bool StimuliRaycastTest
		{
			get
			{
				if (_stimuliRaycastTest == null)
				{
					_stimuliRaycastTest = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "stimuliRaycastTest", cr2w, this);
				}
				return _stimuliRaycastTest;
			}
			set
			{
				if (_stimuliRaycastTest == value)
				{
					return;
				}
				_stimuliRaycastTest = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("stimuliNavigationTest")] 
		public gamebbScriptID_Bool StimuliNavigationTest
		{
			get
			{
				if (_stimuliNavigationTest == null)
				{
					_stimuliNavigationTest = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "stimuliNavigationTest", cr2w, this);
				}
				return _stimuliNavigationTest;
			}
			set
			{
				if (_stimuliNavigationTest == value)
				{
					return;
				}
				_stimuliNavigationTest = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("stimuliConeFilter")] 
		public gamebbScriptID_Bool StimuliConeFilter
		{
			get
			{
				if (_stimuliConeFilter == null)
				{
					_stimuliConeFilter = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "stimuliConeFilter", cr2w, this);
				}
				return _stimuliConeFilter;
			}
			set
			{
				if (_stimuliConeFilter == value)
				{
					return;
				}
				_stimuliConeFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("stimuliAxisFilter")] 
		public gamebbScriptID_Bool StimuliAxisFilter
		{
			get
			{
				if (_stimuliAxisFilter == null)
				{
					_stimuliAxisFilter = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "stimuliAxisFilter", cr2w, this);
				}
				return _stimuliAxisFilter;
			}
			set
			{
				if (_stimuliAxisFilter == value)
				{
					return;
				}
				_stimuliAxisFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("stimuliAxisConstraints")] 
		public gamebbScriptID_Vector4 StimuliAxisConstraints
		{
			get
			{
				if (_stimuliAxisConstraints == null)
				{
					_stimuliAxisConstraints = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "stimuliAxisConstraints", cr2w, this);
				}
				return _stimuliAxisConstraints;
			}
			set
			{
				if (_stimuliAxisConstraints == value)
				{
					return;
				}
				_stimuliAxisConstraints = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("stimType")] 
		public gamebbScriptID_Int32 StimType
		{
			get
			{
				if (_stimType == null)
				{
					_stimType = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "stimType", cr2w, this);
				}
				return _stimType;
			}
			set
			{
				if (_stimType == value)
				{
					return;
				}
				_stimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("value")] 
		public gamebbScriptID_Float Value
		{
			get
			{
				if (_value == null)
				{
					_value = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("flags")] 
		public gamebbScriptID_Variant Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("attack")] 
		public gamebbScriptID_Variant Attack
		{
			get
			{
				if (_attack == null)
				{
					_attack = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "attack", cr2w, this);
				}
				return _attack;
			}
			set
			{
				if (_attack == value)
				{
					return;
				}
				_attack = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("attackId")] 
		public gamebbScriptID_Variant AttackId
		{
			get
			{
				if (_attackId == null)
				{
					_attackId = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "attackId", cr2w, this);
				}
				return _attackId;
			}
			set
			{
				if (_attackId == value)
				{
					return;
				}
				_attackId = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("attackNumber")] 
		public gamebbScriptID_Int32 AttackNumber
		{
			get
			{
				if (_attackNumber == null)
				{
					_attackNumber = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "attackNumber", cr2w, this);
				}
				return _attackNumber;
			}
			set
			{
				if (_attackNumber == value)
				{
					return;
				}
				_attackNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("impactOrientationSlot")] 
		public gamebbScriptID_CName ImpactOrientationSlot
		{
			get
			{
				if (_impactOrientationSlot == null)
				{
					_impactOrientationSlot = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "impactOrientationSlot", cr2w, this);
				}
				return _impactOrientationSlot;
			}
			set
			{
				if (_impactOrientationSlot == value)
				{
					return;
				}
				_impactOrientationSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("statusEffect")] 
		public gamebbScriptID_Variant StatusEffect
		{
			get
			{
				if (_statusEffect == null)
				{
					_statusEffect = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "statusEffect", cr2w, this);
				}
				return _statusEffect;
			}
			set
			{
				if (_statusEffect == value)
				{
					return;
				}
				_statusEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("angle")] 
		public gamebbScriptID_Float Angle
		{
			get
			{
				if (_angle == null)
				{
					_angle = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "angle", cr2w, this);
				}
				return _angle;
			}
			set
			{
				if (_angle == value)
				{
					return;
				}
				_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("fallback_weaponPierce")] 
		public gamebbScriptID_Bool Fallback_weaponPierce
		{
			get
			{
				if (_fallback_weaponPierce == null)
				{
					_fallback_weaponPierce = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "fallback_weaponPierce", cr2w, this);
				}
				return _fallback_weaponPierce;
			}
			set
			{
				if (_fallback_weaponPierce == value)
				{
					return;
				}
				_fallback_weaponPierce = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("fallback_weaponPierceChargeLevel")] 
		public gamebbScriptID_Float Fallback_weaponPierceChargeLevel
		{
			get
			{
				if (_fallback_weaponPierceChargeLevel == null)
				{
					_fallback_weaponPierceChargeLevel = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "fallback_weaponPierceChargeLevel", cr2w, this);
				}
				return _fallback_weaponPierceChargeLevel;
			}
			set
			{
				if (_fallback_weaponPierceChargeLevel == value)
				{
					return;
				}
				_fallback_weaponPierceChargeLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("raycastEnd")] 
		public gamebbScriptID_Vector4 RaycastEnd
		{
			get
			{
				if (_raycastEnd == null)
				{
					_raycastEnd = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "raycastEnd", cr2w, this);
				}
				return _raycastEnd;
			}
			set
			{
				if (_raycastEnd == value)
				{
					return;
				}
				_raycastEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("maxPathLength")] 
		public gamebbScriptID_Float MaxPathLength
		{
			get
			{
				if (_maxPathLength == null)
				{
					_maxPathLength = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "maxPathLength", cr2w, this);
				}
				return _maxPathLength;
			}
			set
			{
				if (_maxPathLength == value)
				{
					return;
				}
				_maxPathLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("effectorRecordName")] 
		public gamebbScriptID_String EffectorRecordName
		{
			get
			{
				if (_effectorRecordName == null)
				{
					_effectorRecordName = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "effectorRecordName", cr2w, this);
				}
				return _effectorRecordName;
			}
			set
			{
				if (_effectorRecordName == value)
				{
					return;
				}
				_effectorRecordName = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("targets")] 
		public gamebbScriptID_Variant Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("highlightType")] 
		public gamebbScriptID_Int32 HighlightType
		{
			get
			{
				if (_highlightType == null)
				{
					_highlightType = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "highlightType", cr2w, this);
				}
				return _highlightType;
			}
			set
			{
				if (_highlightType == value)
				{
					return;
				}
				_highlightType = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("outlineType")] 
		public gamebbScriptID_Int32 OutlineType
		{
			get
			{
				if (_outlineType == null)
				{
					_outlineType = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "outlineType", cr2w, this);
				}
				return _outlineType;
			}
			set
			{
				if (_outlineType == value)
				{
					return;
				}
				_outlineType = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("highlightPriority")] 
		public gamebbScriptID_Int32 HighlightPriority
		{
			get
			{
				if (_highlightPriority == null)
				{
					_highlightPriority = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "highlightPriority", cr2w, this);
				}
				return _highlightPriority;
			}
			set
			{
				if (_highlightPriority == value)
				{
					return;
				}
				_highlightPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("fxResource")] 
		public gamebbScriptID_Variant FxResource
		{
			get
			{
				if (_fxResource == null)
				{
					_fxResource = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "fxResource", cr2w, this);
				}
				return _fxResource;
			}
			set
			{
				if (_fxResource == value)
				{
					return;
				}
				_fxResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("dotCycleDuration")] 
		public gamebbScriptID_Float DotCycleDuration
		{
			get
			{
				if (_dotCycleDuration == null)
				{
					_dotCycleDuration = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "dotCycleDuration", cr2w, this);
				}
				return _dotCycleDuration;
			}
			set
			{
				if (_dotCycleDuration == value)
				{
					return;
				}
				_dotCycleDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("dotLastApplicationTime")] 
		public gamebbScriptID_Float DotLastApplicationTime
		{
			get
			{
				if (_dotLastApplicationTime == null)
				{
					_dotLastApplicationTime = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "dotLastApplicationTime", cr2w, this);
				}
				return _dotLastApplicationTime;
			}
			set
			{
				if (_dotLastApplicationTime == value)
				{
					return;
				}
				_dotLastApplicationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("enable")] 
		public gamebbScriptID_Bool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("slotName")] 
		public gamebbScriptID_CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("targetComponent")] 
		public gamebbScriptID_Variant TargetComponent
		{
			get
			{
				if (_targetComponent == null)
				{
					_targetComponent = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "targetComponent", cr2w, this);
				}
				return _targetComponent;
			}
			set
			{
				if (_targetComponent == value)
				{
					return;
				}
				_targetComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("meleeCleave")] 
		public gamebbScriptID_Bool MeleeCleave
		{
			get
			{
				if (_meleeCleave == null)
				{
					_meleeCleave = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "meleeCleave", cr2w, this);
				}
				return _meleeCleave;
			}
			set
			{
				if (_meleeCleave == value)
				{
					return;
				}
				_meleeCleave = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("highlightedTargets")] 
		public gamebbScriptID_Variant HighlightedTargets
		{
			get
			{
				if (_highlightedTargets == null)
				{
					_highlightedTargets = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "highlightedTargets", cr2w, this);
				}
				return _highlightedTargets;
			}
			set
			{
				if (_highlightedTargets == value)
				{
					return;
				}
				_highlightedTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("forceVisionAppearanceData")] 
		public gamebbScriptID_Variant ForceVisionAppearanceData
		{
			get
			{
				if (_forceVisionAppearanceData == null)
				{
					_forceVisionAppearanceData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "forceVisionAppearanceData", cr2w, this);
				}
				return _forceVisionAppearanceData;
			}
			set
			{
				if (_forceVisionAppearanceData == value)
				{
					return;
				}
				_forceVisionAppearanceData = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("debugBool")] 
		public gamebbScriptID_Bool DebugBool
		{
			get
			{
				if (_debugBool == null)
				{
					_debugBool = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "debugBool", cr2w, this);
				}
				return _debugBool;
			}
			set
			{
				if (_debugBool == value)
				{
					return;
				}
				_debugBool = value;
				PropertySet(this);
			}
		}

		public EffectSharedDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
