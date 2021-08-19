using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityTurretControllerPS : SensorDeviceControllerPS
	{
		private CBool _pendingSecuritySystemDisableRequest;
		private CHandle<EngDemoContainer> _turretSkillChecks;
		private CBool _ignoreSkillcheckGeneration;
		private gameEffectRef _laserGameEffectRef;
		private CString _weaponItemRecordString;
		private CName _vfxNameOnShoot;

		[Ordinal(145)] 
		[RED("pendingSecuritySystemDisableRequest")] 
		public CBool PendingSecuritySystemDisableRequest
		{
			get => GetProperty(ref _pendingSecuritySystemDisableRequest);
			set => SetProperty(ref _pendingSecuritySystemDisableRequest, value);
		}

		[Ordinal(146)] 
		[RED("turretSkillChecks")] 
		public CHandle<EngDemoContainer> TurretSkillChecks
		{
			get => GetProperty(ref _turretSkillChecks);
			set => SetProperty(ref _turretSkillChecks, value);
		}

		[Ordinal(147)] 
		[RED("ignoreSkillcheckGeneration")] 
		public CBool IgnoreSkillcheckGeneration
		{
			get => GetProperty(ref _ignoreSkillcheckGeneration);
			set => SetProperty(ref _ignoreSkillcheckGeneration, value);
		}

		[Ordinal(148)] 
		[RED("laserGameEffectRef")] 
		public gameEffectRef LaserGameEffectRef
		{
			get => GetProperty(ref _laserGameEffectRef);
			set => SetProperty(ref _laserGameEffectRef, value);
		}

		[Ordinal(149)] 
		[RED("weaponItemRecordString")] 
		public CString WeaponItemRecordString
		{
			get => GetProperty(ref _weaponItemRecordString);
			set => SetProperty(ref _weaponItemRecordString, value);
		}

		[Ordinal(150)] 
		[RED("vfxNameOnShoot")] 
		public CName VfxNameOnShoot
		{
			get => GetProperty(ref _vfxNameOnShoot);
			set => SetProperty(ref _vfxNameOnShoot, value);
		}

		public SecurityTurretControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
