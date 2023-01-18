using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectSharedDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("attackStatModList")] 
		public gamebbScriptID_Variant AttackStatModList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("box")] 
		public gamebbScriptID_Vector4 Box
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("charge")] 
		public gamebbScriptID_Float Charge
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public gamebbScriptID_Float Duration
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(4)] 
		[RED("hitCooldown")] 
		public gamebbScriptID_Float HitCooldown
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(5)] 
		[RED("effectName")] 
		public gamebbScriptID_String EffectName
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(6)] 
		[RED("entity")] 
		public gamebbScriptID_EntityPtr Entity
		{
			get => GetPropertyValue<gamebbScriptID_EntityPtr>();
			set => SetPropertyValue<gamebbScriptID_EntityPtr>(value);
		}

		[Ordinal(7)] 
		[RED("forward")] 
		public gamebbScriptID_Vector4 Forward
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("fxPackage")] 
		public gamebbScriptID_Variant FxPackage
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(9)] 
		[RED("attackData")] 
		public gamebbScriptID_Variant AttackData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(10)] 
		[RED("infiniteDuration")] 
		public gamebbScriptID_Bool InfiniteDuration
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(11)] 
		[RED("playerOwnedWeapon")] 
		public gamebbScriptID_Bool PlayerOwnedWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(12)] 
		[RED("position")] 
		public gamebbScriptID_Vector4 Position
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(13)] 
		[RED("muzzlePosition")] 
		public gamebbScriptID_Vector4 MuzzlePosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(14)] 
		[RED("projectileHitEvent")] 
		public gamebbScriptID_Variant ProjectileHitEvent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(15)] 
		[RED("radius")] 
		public gamebbScriptID_Float Radius
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(16)] 
		[RED("range")] 
		public gamebbScriptID_Float Range
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(17)] 
		[RED("renderMaterialOverride")] 
		public gamebbScriptID_Bool RenderMaterialOverride
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(18)] 
		[RED("clearMaterialOverlayOnDetach")] 
		public gamebbScriptID_Bool ClearMaterialOverlayOnDetach
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(19)] 
		[RED("rotation")] 
		public gamebbScriptID_Quaternion Rotation
		{
			get => GetPropertyValue<gamebbScriptID_Quaternion>();
			set => SetPropertyValue<gamebbScriptID_Quaternion>(value);
		}

		[Ordinal(20)] 
		[RED("minRayAngleDiff")] 
		public gamebbScriptID_Float MinRayAngleDiff
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(21)] 
		[RED("statType")] 
		public gamebbScriptID_Int32 StatType
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(22)] 
		[RED("stimuliEvent")] 
		public gamebbScriptID_Variant StimuliEvent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(23)] 
		[RED("stimuliRaycastTest")] 
		public gamebbScriptID_Bool StimuliRaycastTest
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(24)] 
		[RED("stimType")] 
		public gamebbScriptID_Int32 StimType
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(25)] 
		[RED("value")] 
		public gamebbScriptID_Float Value
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(26)] 
		[RED("flags")] 
		public gamebbScriptID_Variant Flags
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(27)] 
		[RED("attack")] 
		public gamebbScriptID_Variant Attack
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(28)] 
		[RED("attackId")] 
		public gamebbScriptID_Variant AttackId
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(29)] 
		[RED("attackNumber")] 
		public gamebbScriptID_Int32 AttackNumber
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(30)] 
		[RED("impactOrientationSlot")] 
		public gamebbScriptID_CName ImpactOrientationSlot
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(31)] 
		[RED("vfxOffset")] 
		public gamebbScriptID_Vector4 VfxOffset
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(32)] 
		[RED("disableVfx")] 
		public gamebbScriptID_Bool DisableVfx
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(33)] 
		[RED("statusEffect")] 
		public gamebbScriptID_Variant StatusEffect
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(34)] 
		[RED("angle")] 
		public gamebbScriptID_Float Angle
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(35)] 
		[RED("fallback_weaponPierce")] 
		public gamebbScriptID_Bool Fallback_weaponPierce
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(36)] 
		[RED("fallback_weaponPierceChargeLevel")] 
		public gamebbScriptID_Float Fallback_weaponPierceChargeLevel
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(37)] 
		[RED("raycastEnd")] 
		public gamebbScriptID_Vector4 RaycastEnd
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(38)] 
		[RED("maxPathLength")] 
		public gamebbScriptID_Float MaxPathLength
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(39)] 
		[RED("effectorRecordName")] 
		public gamebbScriptID_String EffectorRecordName
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(40)] 
		[RED("targets")] 
		public gamebbScriptID_Variant Targets
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(41)] 
		[RED("highlightType")] 
		public gamebbScriptID_Int32 HighlightType
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(42)] 
		[RED("outlineType")] 
		public gamebbScriptID_Int32 OutlineType
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(43)] 
		[RED("highlightPriority")] 
		public gamebbScriptID_Int32 HighlightPriority
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(44)] 
		[RED("fxResource")] 
		public gamebbScriptID_Variant FxResource
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(45)] 
		[RED("dotCycleDuration")] 
		public gamebbScriptID_Float DotCycleDuration
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(46)] 
		[RED("dotLastApplicationTime")] 
		public gamebbScriptID_Float DotLastApplicationTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(47)] 
		[RED("enable")] 
		public gamebbScriptID_Bool Enable
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(48)] 
		[RED("slotName")] 
		public gamebbScriptID_CName SlotName
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(49)] 
		[RED("targetComponent")] 
		public gamebbScriptID_Variant TargetComponent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(50)] 
		[RED("meleeCleave")] 
		public gamebbScriptID_Bool MeleeCleave
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(51)] 
		[RED("highlightedTargets")] 
		public gamebbScriptID_Variant HighlightedTargets
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(52)] 
		[RED("forceVisionAppearanceData")] 
		public gamebbScriptID_Variant ForceVisionAppearanceData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(53)] 
		[RED("tickRateOverride")] 
		public gamebbScriptID_Float TickRateOverride
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(54)] 
		[RED("debugBool")] 
		public gamebbScriptID_Bool DebugBool
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public EffectSharedDataDef()
		{
			AttackStatModList = new();
			Box = new();
			Charge = new();
			Duration = new();
			HitCooldown = new();
			EffectName = new();
			Entity = new();
			Forward = new();
			FxPackage = new();
			AttackData = new();
			InfiniteDuration = new();
			PlayerOwnedWeapon = new();
			Position = new();
			MuzzlePosition = new();
			ProjectileHitEvent = new();
			Radius = new();
			Range = new();
			RenderMaterialOverride = new();
			ClearMaterialOverlayOnDetach = new();
			Rotation = new();
			MinRayAngleDiff = new();
			StatType = new();
			StimuliEvent = new();
			StimuliRaycastTest = new();
			StimType = new();
			Value = new();
			Flags = new();
			Attack = new();
			AttackId = new();
			AttackNumber = new();
			ImpactOrientationSlot = new();
			VfxOffset = new();
			DisableVfx = new();
			StatusEffect = new();
			Angle = new();
			Fallback_weaponPierce = new();
			Fallback_weaponPierceChargeLevel = new();
			RaycastEnd = new();
			MaxPathLength = new();
			EffectorRecordName = new();
			Targets = new();
			HighlightType = new();
			OutlineType = new();
			HighlightPriority = new();
			FxResource = new();
			DotCycleDuration = new();
			DotLastApplicationTime = new();
			Enable = new();
			SlotName = new();
			TargetComponent = new();
			MeleeCleave = new();
			HighlightedTargets = new();
			ForceVisionAppearanceData = new();
			TickRateOverride = new();
			DebugBool = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
