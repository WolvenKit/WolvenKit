using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioNpcWeaponSettings : audioWeaponSettings
	{
		[Ordinal(10)] 
		[RED("gunChoir")] 
		public CName GunChoir
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("tails")] 
		public CName Tails
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("obstructionEnabled")] 
		public CBool ObstructionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("repositionEnabled")] 
		public CBool RepositionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("disablePathfinding")] 
		public CBool DisablePathfinding
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("voiceSwitchCooldown")] 
		public CFloat VoiceSwitchCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("reloadSound")] 
		public CName ReloadSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("quickMeleeAttackSound")] 
		public CName QuickMeleeAttackSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("quickMeleeHitSound")] 
		public CName QuickMeleeHitSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioNpcWeaponSettings()
		{
			WeaponHandlingSettings = new audioWeaponHandlingSettings();
			FireModeSounds = new audioWeaponFireModeSounds();
			VoiceSwitchCooldown = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
