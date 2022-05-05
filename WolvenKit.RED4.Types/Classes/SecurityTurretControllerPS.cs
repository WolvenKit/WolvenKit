using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityTurretControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(145)] 
		[RED("pendingSecuritySystemDisableRequest")] 
		public CBool PendingSecuritySystemDisableRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(146)] 
		[RED("turretSkillChecks")] 
		public CHandle<EngDemoContainer> TurretSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(147)] 
		[RED("ignoreSkillcheckGeneration")] 
		public CBool IgnoreSkillcheckGeneration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(148)] 
		[RED("laserGameEffectRef")] 
		public gameEffectRef LaserGameEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(149)] 
		[RED("weaponItemRecordString")] 
		public CString WeaponItemRecordString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(150)] 
		[RED("vfxNameOnShoot")] 
		public CName VfxNameOnShoot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SecurityTurretControllerPS()
		{
			DeviceName = "LocKey#121";
			TweakDBRecord = 96702420141;
			TweakDBDescriptionRecord = 147741407213;
			LookAtPresetVert = 116799757519;
			LookAtPresetHor = 125000267963;
			LaserGameEffectRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
