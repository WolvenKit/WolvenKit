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

		[Ordinal(144)] 
		[RED("pendingSecuritySystemDisableRequest")] 
		public CBool PendingSecuritySystemDisableRequest
		{
			get
			{
				if (_pendingSecuritySystemDisableRequest == null)
				{
					_pendingSecuritySystemDisableRequest = (CBool) CR2WTypeManager.Create("Bool", "pendingSecuritySystemDisableRequest", cr2w, this);
				}
				return _pendingSecuritySystemDisableRequest;
			}
			set
			{
				if (_pendingSecuritySystemDisableRequest == value)
				{
					return;
				}
				_pendingSecuritySystemDisableRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(145)] 
		[RED("turretSkillChecks")] 
		public CHandle<EngDemoContainer> TurretSkillChecks
		{
			get
			{
				if (_turretSkillChecks == null)
				{
					_turretSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "turretSkillChecks", cr2w, this);
				}
				return _turretSkillChecks;
			}
			set
			{
				if (_turretSkillChecks == value)
				{
					return;
				}
				_turretSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(146)] 
		[RED("ignoreSkillcheckGeneration")] 
		public CBool IgnoreSkillcheckGeneration
		{
			get
			{
				if (_ignoreSkillcheckGeneration == null)
				{
					_ignoreSkillcheckGeneration = (CBool) CR2WTypeManager.Create("Bool", "ignoreSkillcheckGeneration", cr2w, this);
				}
				return _ignoreSkillcheckGeneration;
			}
			set
			{
				if (_ignoreSkillcheckGeneration == value)
				{
					return;
				}
				_ignoreSkillcheckGeneration = value;
				PropertySet(this);
			}
		}

		[Ordinal(147)] 
		[RED("laserGameEffectRef")] 
		public gameEffectRef LaserGameEffectRef
		{
			get
			{
				if (_laserGameEffectRef == null)
				{
					_laserGameEffectRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "laserGameEffectRef", cr2w, this);
				}
				return _laserGameEffectRef;
			}
			set
			{
				if (_laserGameEffectRef == value)
				{
					return;
				}
				_laserGameEffectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(148)] 
		[RED("weaponItemRecordString")] 
		public CString WeaponItemRecordString
		{
			get
			{
				if (_weaponItemRecordString == null)
				{
					_weaponItemRecordString = (CString) CR2WTypeManager.Create("String", "weaponItemRecordString", cr2w, this);
				}
				return _weaponItemRecordString;
			}
			set
			{
				if (_weaponItemRecordString == value)
				{
					return;
				}
				_weaponItemRecordString = value;
				PropertySet(this);
			}
		}

		[Ordinal(149)] 
		[RED("vfxNameOnShoot")] 
		public CName VfxNameOnShoot
		{
			get
			{
				if (_vfxNameOnShoot == null)
				{
					_vfxNameOnShoot = (CName) CR2WTypeManager.Create("CName", "vfxNameOnShoot", cr2w, this);
				}
				return _vfxNameOnShoot;
			}
			set
			{
				if (_vfxNameOnShoot == value)
				{
					return;
				}
				_vfxNameOnShoot = value;
				PropertySet(this);
			}
		}

		public SecurityTurretControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
