using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityTurretControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(150)] 
		[RED("pendingSecuritySystemDisableRequest")] 
		public CBool PendingSecuritySystemDisableRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(151)] 
		[RED("turretSkillChecks")] 
		public CHandle<EngDemoContainer> TurretSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(152)] 
		[RED("ignoreSkillcheckGeneration")] 
		public CBool IgnoreSkillcheckGeneration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(153)] 
		[RED("laserGameEffectRef")] 
		public gameEffectRef LaserGameEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(154)] 
		[RED("weaponItemRecordString")] 
		public CString WeaponItemRecordString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(155)] 
		[RED("vfxNameOnShoot")] 
		public CName VfxNameOnShoot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SecurityTurretControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
