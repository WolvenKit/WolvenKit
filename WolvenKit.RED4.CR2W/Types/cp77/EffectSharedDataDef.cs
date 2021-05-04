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
		private gamebbScriptID_Bool _clearMaterialOverlayOnDetach;
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
			get => GetProperty(ref _attackStatModList);
			set => SetProperty(ref _attackStatModList, value);
		}

		[Ordinal(1)] 
		[RED("box")] 
		public gamebbScriptID_Vector4 Box
		{
			get => GetProperty(ref _box);
			set => SetProperty(ref _box, value);
		}

		[Ordinal(2)] 
		[RED("charge")] 
		public gamebbScriptID_Float Charge
		{
			get => GetProperty(ref _charge);
			set => SetProperty(ref _charge, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public gamebbScriptID_Float Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("hitCooldown")] 
		public gamebbScriptID_Float HitCooldown
		{
			get => GetProperty(ref _hitCooldown);
			set => SetProperty(ref _hitCooldown, value);
		}

		[Ordinal(5)] 
		[RED("effectName")] 
		public gamebbScriptID_String EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(6)] 
		[RED("entity")] 
		public gamebbScriptID_EntityPtr Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(7)] 
		[RED("forward")] 
		public gamebbScriptID_Vector4 Forward
		{
			get => GetProperty(ref _forward);
			set => SetProperty(ref _forward, value);
		}

		[Ordinal(8)] 
		[RED("fxPackage")] 
		public gamebbScriptID_Variant FxPackage
		{
			get => GetProperty(ref _fxPackage);
			set => SetProperty(ref _fxPackage, value);
		}

		[Ordinal(9)] 
		[RED("attackData")] 
		public gamebbScriptID_Variant AttackData
		{
			get => GetProperty(ref _attackData);
			set => SetProperty(ref _attackData, value);
		}

		[Ordinal(10)] 
		[RED("infiniteDuration")] 
		public gamebbScriptID_Bool InfiniteDuration
		{
			get => GetProperty(ref _infiniteDuration);
			set => SetProperty(ref _infiniteDuration, value);
		}

		[Ordinal(11)] 
		[RED("playerOwnedWeapon")] 
		public gamebbScriptID_Bool PlayerOwnedWeapon
		{
			get => GetProperty(ref _playerOwnedWeapon);
			set => SetProperty(ref _playerOwnedWeapon, value);
		}

		[Ordinal(12)] 
		[RED("position")] 
		public gamebbScriptID_Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(13)] 
		[RED("muzzlePosition")] 
		public gamebbScriptID_Vector4 MuzzlePosition
		{
			get => GetProperty(ref _muzzlePosition);
			set => SetProperty(ref _muzzlePosition, value);
		}

		[Ordinal(14)] 
		[RED("projectileHitEvent")] 
		public gamebbScriptID_Variant ProjectileHitEvent
		{
			get => GetProperty(ref _projectileHitEvent);
			set => SetProperty(ref _projectileHitEvent, value);
		}

		[Ordinal(15)] 
		[RED("radius")] 
		public gamebbScriptID_Float Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(16)] 
		[RED("range")] 
		public gamebbScriptID_Float Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(17)] 
		[RED("renderMaterialOverride")] 
		public gamebbScriptID_Bool RenderMaterialOverride
		{
			get => GetProperty(ref _renderMaterialOverride);
			set => SetProperty(ref _renderMaterialOverride, value);
		}

		[Ordinal(18)] 
		[RED("clearMaterialOverlayOnDetach")] 
		public gamebbScriptID_Bool ClearMaterialOverlayOnDetach
		{
			get => GetProperty(ref _clearMaterialOverlayOnDetach);
			set => SetProperty(ref _clearMaterialOverlayOnDetach, value);
		}

		[Ordinal(19)] 
		[RED("rotation")] 
		public gamebbScriptID_Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(20)] 
		[RED("minRayAngleDiff")] 
		public gamebbScriptID_Float MinRayAngleDiff
		{
			get => GetProperty(ref _minRayAngleDiff);
			set => SetProperty(ref _minRayAngleDiff, value);
		}

		[Ordinal(21)] 
		[RED("statType")] 
		public gamebbScriptID_Int32 StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(22)] 
		[RED("stimuliEvent")] 
		public gamebbScriptID_Variant StimuliEvent
		{
			get => GetProperty(ref _stimuliEvent);
			set => SetProperty(ref _stimuliEvent, value);
		}

		[Ordinal(23)] 
		[RED("stimuliRaycastTest")] 
		public gamebbScriptID_Bool StimuliRaycastTest
		{
			get => GetProperty(ref _stimuliRaycastTest);
			set => SetProperty(ref _stimuliRaycastTest, value);
		}

		[Ordinal(24)] 
		[RED("stimuliNavigationTest")] 
		public gamebbScriptID_Bool StimuliNavigationTest
		{
			get => GetProperty(ref _stimuliNavigationTest);
			set => SetProperty(ref _stimuliNavigationTest, value);
		}

		[Ordinal(25)] 
		[RED("stimuliConeFilter")] 
		public gamebbScriptID_Bool StimuliConeFilter
		{
			get => GetProperty(ref _stimuliConeFilter);
			set => SetProperty(ref _stimuliConeFilter, value);
		}

		[Ordinal(26)] 
		[RED("stimuliAxisFilter")] 
		public gamebbScriptID_Bool StimuliAxisFilter
		{
			get => GetProperty(ref _stimuliAxisFilter);
			set => SetProperty(ref _stimuliAxisFilter, value);
		}

		[Ordinal(27)] 
		[RED("stimuliAxisConstraints")] 
		public gamebbScriptID_Vector4 StimuliAxisConstraints
		{
			get => GetProperty(ref _stimuliAxisConstraints);
			set => SetProperty(ref _stimuliAxisConstraints, value);
		}

		[Ordinal(28)] 
		[RED("stimType")] 
		public gamebbScriptID_Int32 StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		[Ordinal(29)] 
		[RED("value")] 
		public gamebbScriptID_Float Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(30)] 
		[RED("flags")] 
		public gamebbScriptID_Variant Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(31)] 
		[RED("attack")] 
		public gamebbScriptID_Variant Attack
		{
			get => GetProperty(ref _attack);
			set => SetProperty(ref _attack, value);
		}

		[Ordinal(32)] 
		[RED("attackId")] 
		public gamebbScriptID_Variant AttackId
		{
			get => GetProperty(ref _attackId);
			set => SetProperty(ref _attackId, value);
		}

		[Ordinal(33)] 
		[RED("attackNumber")] 
		public gamebbScriptID_Int32 AttackNumber
		{
			get => GetProperty(ref _attackNumber);
			set => SetProperty(ref _attackNumber, value);
		}

		[Ordinal(34)] 
		[RED("impactOrientationSlot")] 
		public gamebbScriptID_CName ImpactOrientationSlot
		{
			get => GetProperty(ref _impactOrientationSlot);
			set => SetProperty(ref _impactOrientationSlot, value);
		}

		[Ordinal(35)] 
		[RED("statusEffect")] 
		public gamebbScriptID_Variant StatusEffect
		{
			get => GetProperty(ref _statusEffect);
			set => SetProperty(ref _statusEffect, value);
		}

		[Ordinal(36)] 
		[RED("angle")] 
		public gamebbScriptID_Float Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(37)] 
		[RED("fallback_weaponPierce")] 
		public gamebbScriptID_Bool Fallback_weaponPierce
		{
			get => GetProperty(ref _fallback_weaponPierce);
			set => SetProperty(ref _fallback_weaponPierce, value);
		}

		[Ordinal(38)] 
		[RED("fallback_weaponPierceChargeLevel")] 
		public gamebbScriptID_Float Fallback_weaponPierceChargeLevel
		{
			get => GetProperty(ref _fallback_weaponPierceChargeLevel);
			set => SetProperty(ref _fallback_weaponPierceChargeLevel, value);
		}

		[Ordinal(39)] 
		[RED("raycastEnd")] 
		public gamebbScriptID_Vector4 RaycastEnd
		{
			get => GetProperty(ref _raycastEnd);
			set => SetProperty(ref _raycastEnd, value);
		}

		[Ordinal(40)] 
		[RED("maxPathLength")] 
		public gamebbScriptID_Float MaxPathLength
		{
			get => GetProperty(ref _maxPathLength);
			set => SetProperty(ref _maxPathLength, value);
		}

		[Ordinal(41)] 
		[RED("effectorRecordName")] 
		public gamebbScriptID_String EffectorRecordName
		{
			get => GetProperty(ref _effectorRecordName);
			set => SetProperty(ref _effectorRecordName, value);
		}

		[Ordinal(42)] 
		[RED("targets")] 
		public gamebbScriptID_Variant Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(43)] 
		[RED("highlightType")] 
		public gamebbScriptID_Int32 HighlightType
		{
			get => GetProperty(ref _highlightType);
			set => SetProperty(ref _highlightType, value);
		}

		[Ordinal(44)] 
		[RED("outlineType")] 
		public gamebbScriptID_Int32 OutlineType
		{
			get => GetProperty(ref _outlineType);
			set => SetProperty(ref _outlineType, value);
		}

		[Ordinal(45)] 
		[RED("highlightPriority")] 
		public gamebbScriptID_Int32 HighlightPriority
		{
			get => GetProperty(ref _highlightPriority);
			set => SetProperty(ref _highlightPriority, value);
		}

		[Ordinal(46)] 
		[RED("fxResource")] 
		public gamebbScriptID_Variant FxResource
		{
			get => GetProperty(ref _fxResource);
			set => SetProperty(ref _fxResource, value);
		}

		[Ordinal(47)] 
		[RED("dotCycleDuration")] 
		public gamebbScriptID_Float DotCycleDuration
		{
			get => GetProperty(ref _dotCycleDuration);
			set => SetProperty(ref _dotCycleDuration, value);
		}

		[Ordinal(48)] 
		[RED("dotLastApplicationTime")] 
		public gamebbScriptID_Float DotLastApplicationTime
		{
			get => GetProperty(ref _dotLastApplicationTime);
			set => SetProperty(ref _dotLastApplicationTime, value);
		}

		[Ordinal(49)] 
		[RED("enable")] 
		public gamebbScriptID_Bool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(50)] 
		[RED("slotName")] 
		public gamebbScriptID_CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(51)] 
		[RED("targetComponent")] 
		public gamebbScriptID_Variant TargetComponent
		{
			get => GetProperty(ref _targetComponent);
			set => SetProperty(ref _targetComponent, value);
		}

		[Ordinal(52)] 
		[RED("meleeCleave")] 
		public gamebbScriptID_Bool MeleeCleave
		{
			get => GetProperty(ref _meleeCleave);
			set => SetProperty(ref _meleeCleave, value);
		}

		[Ordinal(53)] 
		[RED("highlightedTargets")] 
		public gamebbScriptID_Variant HighlightedTargets
		{
			get => GetProperty(ref _highlightedTargets);
			set => SetProperty(ref _highlightedTargets, value);
		}

		[Ordinal(54)] 
		[RED("forceVisionAppearanceData")] 
		public gamebbScriptID_Variant ForceVisionAppearanceData
		{
			get => GetProperty(ref _forceVisionAppearanceData);
			set => SetProperty(ref _forceVisionAppearanceData, value);
		}

		[Ordinal(55)] 
		[RED("debugBool")] 
		public gamebbScriptID_Bool DebugBool
		{
			get => GetProperty(ref _debugBool);
			set => SetProperty(ref _debugBool, value);
		}

		public EffectSharedDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
