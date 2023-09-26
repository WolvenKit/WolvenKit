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
		[RED("height")] 
		public gamebbScriptID_Float Height
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(18)] 
		[RED("initRange")] 
		public gamebbScriptID_Float InitRange
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(19)] 
		[RED("width")] 
		public gamebbScriptID_Float Width
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(20)] 
		[RED("axisConstraints")] 
		public gamebbScriptID_Vector4 AxisConstraints
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(21)] 
		[RED("renderMaterialOverride")] 
		public gamebbScriptID_Bool RenderMaterialOverride
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(22)] 
		[RED("clearMaterialOverlayOnDetach")] 
		public gamebbScriptID_Bool ClearMaterialOverlayOnDetach
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(23)] 
		[RED("rotation")] 
		public gamebbScriptID_Quaternion Rotation
		{
			get => GetPropertyValue<gamebbScriptID_Quaternion>();
			set => SetPropertyValue<gamebbScriptID_Quaternion>(value);
		}

		[Ordinal(24)] 
		[RED("minRayAngleDiff")] 
		public gamebbScriptID_Float MinRayAngleDiff
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(25)] 
		[RED("statType")] 
		public gamebbScriptID_Int32 StatType
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(26)] 
		[RED("stimuliEvent")] 
		public gamebbScriptID_Variant StimuliEvent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(27)] 
		[RED("stimuliRaycastTest")] 
		public gamebbScriptID_Bool StimuliRaycastTest
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(28)] 
		[RED("stimType")] 
		public gamebbScriptID_Int32 StimType
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(29)] 
		[RED("value")] 
		public gamebbScriptID_Float Value
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(30)] 
		[RED("flags")] 
		public gamebbScriptID_Variant Flags
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(31)] 
		[RED("attack")] 
		public gamebbScriptID_Variant Attack
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(32)] 
		[RED("attackId")] 
		public gamebbScriptID_Variant AttackId
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(33)] 
		[RED("attackNumber")] 
		public gamebbScriptID_Int32 AttackNumber
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(34)] 
		[RED("impactOrientationSlot")] 
		public gamebbScriptID_CName ImpactOrientationSlot
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(35)] 
		[RED("vfxOffset")] 
		public gamebbScriptID_Vector4 VfxOffset
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(36)] 
		[RED("disableVfx")] 
		public gamebbScriptID_Bool DisableVfx
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(37)] 
		[RED("enableImpulseFalloff")] 
		public gamebbScriptID_Bool EnableImpulseFalloff
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(38)] 
		[RED("impulseFalloffFactor")] 
		public gamebbScriptID_Float ImpulseFalloffFactor
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(39)] 
		[RED("statusEffect")] 
		public gamebbScriptID_Variant StatusEffect
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(40)] 
		[RED("angle")] 
		public gamebbScriptID_Float Angle
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(41)] 
		[RED("fallback_weaponPierce")] 
		public gamebbScriptID_Bool Fallback_weaponPierce
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(42)] 
		[RED("fallback_weaponPierceChargeLevel")] 
		public gamebbScriptID_Float Fallback_weaponPierceChargeLevel
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(43)] 
		[RED("raycastEnd")] 
		public gamebbScriptID_Vector4 RaycastEnd
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(44)] 
		[RED("maxPathLength")] 
		public gamebbScriptID_Float MaxPathLength
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(45)] 
		[RED("effectorRecordName")] 
		public gamebbScriptID_String EffectorRecordName
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(46)] 
		[RED("targets")] 
		public gamebbScriptID_Variant Targets
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(47)] 
		[RED("highlightType")] 
		public gamebbScriptID_Int32 HighlightType
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(48)] 
		[RED("outlineType")] 
		public gamebbScriptID_Int32 OutlineType
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(49)] 
		[RED("highlightPriority")] 
		public gamebbScriptID_Int32 HighlightPriority
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(50)] 
		[RED("fxResource")] 
		public gamebbScriptID_Variant FxResource
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(51)] 
		[RED("dotCycleDuration")] 
		public gamebbScriptID_Float DotCycleDuration
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(52)] 
		[RED("dotLastApplicationTime")] 
		public gamebbScriptID_Float DotLastApplicationTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(53)] 
		[RED("enable")] 
		public gamebbScriptID_Bool Enable
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(54)] 
		[RED("slotName")] 
		public gamebbScriptID_CName SlotName
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(55)] 
		[RED("targetComponent")] 
		public gamebbScriptID_Variant TargetComponent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(56)] 
		[RED("meleeCleave")] 
		public gamebbScriptID_Bool MeleeCleave
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(57)] 
		[RED("inTPP")] 
		public gamebbScriptID_Bool InTPP
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(58)] 
		[RED("tppScale")] 
		public gamebbScriptID_Float TppScale
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(59)] 
		[RED("highlightedTargets")] 
		public gamebbScriptID_Variant HighlightedTargets
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(60)] 
		[RED("forceVisionAppearanceData")] 
		public gamebbScriptID_Variant ForceVisionAppearanceData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(61)] 
		[RED("tickRateOverride")] 
		public gamebbScriptID_Float TickRateOverride
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(62)] 
		[RED("randRoll")] 
		public gamebbScriptID_Float RandRoll
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(63)] 
		[RED("ignoreMountedVehicleCollision")] 
		public gamebbScriptID_Bool IgnoreMountedVehicleCollision
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(64)] 
		[RED("debugBool")] 
		public gamebbScriptID_Bool DebugBool
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public EffectSharedDataDef()
		{
			AttackStatModList = new gamebbScriptID_Variant();
			Box = new gamebbScriptID_Vector4();
			Charge = new gamebbScriptID_Float();
			Duration = new gamebbScriptID_Float();
			HitCooldown = new gamebbScriptID_Float();
			EffectName = new gamebbScriptID_String();
			Entity = new gamebbScriptID_EntityPtr();
			Forward = new gamebbScriptID_Vector4();
			FxPackage = new gamebbScriptID_Variant();
			AttackData = new gamebbScriptID_Variant();
			InfiniteDuration = new gamebbScriptID_Bool();
			PlayerOwnedWeapon = new gamebbScriptID_Bool();
			Position = new gamebbScriptID_Vector4();
			MuzzlePosition = new gamebbScriptID_Vector4();
			ProjectileHitEvent = new gamebbScriptID_Variant();
			Radius = new gamebbScriptID_Float();
			Range = new gamebbScriptID_Float();
			Height = new gamebbScriptID_Float();
			InitRange = new gamebbScriptID_Float();
			Width = new gamebbScriptID_Float();
			AxisConstraints = new gamebbScriptID_Vector4();
			RenderMaterialOverride = new gamebbScriptID_Bool();
			ClearMaterialOverlayOnDetach = new gamebbScriptID_Bool();
			Rotation = new gamebbScriptID_Quaternion();
			MinRayAngleDiff = new gamebbScriptID_Float();
			StatType = new gamebbScriptID_Int32();
			StimuliEvent = new gamebbScriptID_Variant();
			StimuliRaycastTest = new gamebbScriptID_Bool();
			StimType = new gamebbScriptID_Int32();
			Value = new gamebbScriptID_Float();
			Flags = new gamebbScriptID_Variant();
			Attack = new gamebbScriptID_Variant();
			AttackId = new gamebbScriptID_Variant();
			AttackNumber = new gamebbScriptID_Int32();
			ImpactOrientationSlot = new gamebbScriptID_CName();
			VfxOffset = new gamebbScriptID_Vector4();
			DisableVfx = new gamebbScriptID_Bool();
			EnableImpulseFalloff = new gamebbScriptID_Bool();
			ImpulseFalloffFactor = new gamebbScriptID_Float();
			StatusEffect = new gamebbScriptID_Variant();
			Angle = new gamebbScriptID_Float();
			Fallback_weaponPierce = new gamebbScriptID_Bool();
			Fallback_weaponPierceChargeLevel = new gamebbScriptID_Float();
			RaycastEnd = new gamebbScriptID_Vector4();
			MaxPathLength = new gamebbScriptID_Float();
			EffectorRecordName = new gamebbScriptID_String();
			Targets = new gamebbScriptID_Variant();
			HighlightType = new gamebbScriptID_Int32();
			OutlineType = new gamebbScriptID_Int32();
			HighlightPriority = new gamebbScriptID_Int32();
			FxResource = new gamebbScriptID_Variant();
			DotCycleDuration = new gamebbScriptID_Float();
			DotLastApplicationTime = new gamebbScriptID_Float();
			Enable = new gamebbScriptID_Bool();
			SlotName = new gamebbScriptID_CName();
			TargetComponent = new gamebbScriptID_Variant();
			MeleeCleave = new gamebbScriptID_Bool();
			InTPP = new gamebbScriptID_Bool();
			TppScale = new gamebbScriptID_Float();
			HighlightedTargets = new gamebbScriptID_Variant();
			ForceVisionAppearanceData = new gamebbScriptID_Variant();
			TickRateOverride = new gamebbScriptID_Float();
			RandRoll = new gamebbScriptID_Float();
			IgnoreMountedVehicleCollision = new gamebbScriptID_Bool();
			DebugBool = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
