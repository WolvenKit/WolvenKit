
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffectPlayerData_Record
	{
		[RED("airRecoveryAnimDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat AirRecoveryAnimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("blockMovement")]
		[REDProperty(IsIgnored = true)]
		public CBool BlockMovement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("cameraInputInterference")]
		[REDProperty(IsIgnored = true)]
		public CBool CameraInputInterference
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("cameraShakeStrength")]
		[REDProperty(IsIgnored = true)]
		public CFloat CameraShakeStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("disableCrouch")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableCrouch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("disableDodge")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableDodge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("disableJump")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableJump
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("disableSprint")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableSprint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forceSafeWeapon")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceSafeWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forceUnequipWeapon")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceUnequipWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("impulseDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ImpulseDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("jamWeapon")]
		[REDProperty(IsIgnored = true)]
		public CBool JamWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("landAnimDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat LandAnimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("recoveryAnimDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat RecoveryAnimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rotateToSource")]
		[REDProperty(IsIgnored = true)]
		public CBool RotateToSource
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("scaleImpulseDistance")]
		[REDProperty(IsIgnored = true)]
		public CBool ScaleImpulseDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("startupAnimDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartupAnimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("startupAnimInterruptPoint")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartupAnimInterruptPoint
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("statusEffectVariation")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffectVariation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
