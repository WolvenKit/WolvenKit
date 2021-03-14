using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalMaterialSettings : audioAudioMetadata
	{
		private CName _softImpact;
		private CName _solidImpact;
		private CName _hardImpact;
		private CBool _useFoliageSystem;
		private CBool _enableRollingOrScraping;
		private CName _scrape;
		private CName _roll;
		private CEnum<audioMaterialHardnessOverride> _materialHardnessOverride;
		private CBool _collideOnlyOnce;
		private CName _bulletImpact;
		private CName _bulletImpactSniper;
		private CName _bulletImpactShotgun;
		private CName _bulletImpactRail;
		private CName _bulletImpactNpc;
		private CName _bulletImpactNpcSniper;
		private CName _bulletImpactNpcAuto;
		private CName _bulletImpactNpcShotgun;
		private CName _bulletImpactNpcRail;

		[Ordinal(1)] 
		[RED("softImpact")] 
		public CName SoftImpact
		{
			get
			{
				if (_softImpact == null)
				{
					_softImpact = (CName) CR2WTypeManager.Create("CName", "softImpact", cr2w, this);
				}
				return _softImpact;
			}
			set
			{
				if (_softImpact == value)
				{
					return;
				}
				_softImpact = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("solidImpact")] 
		public CName SolidImpact
		{
			get
			{
				if (_solidImpact == null)
				{
					_solidImpact = (CName) CR2WTypeManager.Create("CName", "solidImpact", cr2w, this);
				}
				return _solidImpact;
			}
			set
			{
				if (_solidImpact == value)
				{
					return;
				}
				_solidImpact = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hardImpact")] 
		public CName HardImpact
		{
			get
			{
				if (_hardImpact == null)
				{
					_hardImpact = (CName) CR2WTypeManager.Create("CName", "hardImpact", cr2w, this);
				}
				return _hardImpact;
			}
			set
			{
				if (_hardImpact == value)
				{
					return;
				}
				_hardImpact = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useFoliageSystem")] 
		public CBool UseFoliageSystem
		{
			get
			{
				if (_useFoliageSystem == null)
				{
					_useFoliageSystem = (CBool) CR2WTypeManager.Create("Bool", "useFoliageSystem", cr2w, this);
				}
				return _useFoliageSystem;
			}
			set
			{
				if (_useFoliageSystem == value)
				{
					return;
				}
				_useFoliageSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("enableRollingOrScraping")] 
		public CBool EnableRollingOrScraping
		{
			get
			{
				if (_enableRollingOrScraping == null)
				{
					_enableRollingOrScraping = (CBool) CR2WTypeManager.Create("Bool", "enableRollingOrScraping", cr2w, this);
				}
				return _enableRollingOrScraping;
			}
			set
			{
				if (_enableRollingOrScraping == value)
				{
					return;
				}
				_enableRollingOrScraping = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scrape")] 
		public CName Scrape
		{
			get
			{
				if (_scrape == null)
				{
					_scrape = (CName) CR2WTypeManager.Create("CName", "scrape", cr2w, this);
				}
				return _scrape;
			}
			set
			{
				if (_scrape == value)
				{
					return;
				}
				_scrape = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("roll")] 
		public CName Roll
		{
			get
			{
				if (_roll == null)
				{
					_roll = (CName) CR2WTypeManager.Create("CName", "roll", cr2w, this);
				}
				return _roll;
			}
			set
			{
				if (_roll == value)
				{
					return;
				}
				_roll = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("materialHardnessOverride")] 
		public CEnum<audioMaterialHardnessOverride> MaterialHardnessOverride
		{
			get
			{
				if (_materialHardnessOverride == null)
				{
					_materialHardnessOverride = (CEnum<audioMaterialHardnessOverride>) CR2WTypeManager.Create("audioMaterialHardnessOverride", "materialHardnessOverride", cr2w, this);
				}
				return _materialHardnessOverride;
			}
			set
			{
				if (_materialHardnessOverride == value)
				{
					return;
				}
				_materialHardnessOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("collideOnlyOnce")] 
		public CBool CollideOnlyOnce
		{
			get
			{
				if (_collideOnlyOnce == null)
				{
					_collideOnlyOnce = (CBool) CR2WTypeManager.Create("Bool", "collideOnlyOnce", cr2w, this);
				}
				return _collideOnlyOnce;
			}
			set
			{
				if (_collideOnlyOnce == value)
				{
					return;
				}
				_collideOnlyOnce = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bulletImpact")] 
		public CName BulletImpact
		{
			get
			{
				if (_bulletImpact == null)
				{
					_bulletImpact = (CName) CR2WTypeManager.Create("CName", "bulletImpact", cr2w, this);
				}
				return _bulletImpact;
			}
			set
			{
				if (_bulletImpact == value)
				{
					return;
				}
				_bulletImpact = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("bulletImpactSniper")] 
		public CName BulletImpactSniper
		{
			get
			{
				if (_bulletImpactSniper == null)
				{
					_bulletImpactSniper = (CName) CR2WTypeManager.Create("CName", "bulletImpactSniper", cr2w, this);
				}
				return _bulletImpactSniper;
			}
			set
			{
				if (_bulletImpactSniper == value)
				{
					return;
				}
				_bulletImpactSniper = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("bulletImpactShotgun")] 
		public CName BulletImpactShotgun
		{
			get
			{
				if (_bulletImpactShotgun == null)
				{
					_bulletImpactShotgun = (CName) CR2WTypeManager.Create("CName", "bulletImpactShotgun", cr2w, this);
				}
				return _bulletImpactShotgun;
			}
			set
			{
				if (_bulletImpactShotgun == value)
				{
					return;
				}
				_bulletImpactShotgun = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bulletImpactRail")] 
		public CName BulletImpactRail
		{
			get
			{
				if (_bulletImpactRail == null)
				{
					_bulletImpactRail = (CName) CR2WTypeManager.Create("CName", "bulletImpactRail", cr2w, this);
				}
				return _bulletImpactRail;
			}
			set
			{
				if (_bulletImpactRail == value)
				{
					return;
				}
				_bulletImpactRail = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bulletImpactNpc")] 
		public CName BulletImpactNpc
		{
			get
			{
				if (_bulletImpactNpc == null)
				{
					_bulletImpactNpc = (CName) CR2WTypeManager.Create("CName", "bulletImpactNpc", cr2w, this);
				}
				return _bulletImpactNpc;
			}
			set
			{
				if (_bulletImpactNpc == value)
				{
					return;
				}
				_bulletImpactNpc = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bulletImpactNpcSniper")] 
		public CName BulletImpactNpcSniper
		{
			get
			{
				if (_bulletImpactNpcSniper == null)
				{
					_bulletImpactNpcSniper = (CName) CR2WTypeManager.Create("CName", "bulletImpactNpcSniper", cr2w, this);
				}
				return _bulletImpactNpcSniper;
			}
			set
			{
				if (_bulletImpactNpcSniper == value)
				{
					return;
				}
				_bulletImpactNpcSniper = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("bulletImpactNpcAuto")] 
		public CName BulletImpactNpcAuto
		{
			get
			{
				if (_bulletImpactNpcAuto == null)
				{
					_bulletImpactNpcAuto = (CName) CR2WTypeManager.Create("CName", "bulletImpactNpcAuto", cr2w, this);
				}
				return _bulletImpactNpcAuto;
			}
			set
			{
				if (_bulletImpactNpcAuto == value)
				{
					return;
				}
				_bulletImpactNpcAuto = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("bulletImpactNpcShotgun")] 
		public CName BulletImpactNpcShotgun
		{
			get
			{
				if (_bulletImpactNpcShotgun == null)
				{
					_bulletImpactNpcShotgun = (CName) CR2WTypeManager.Create("CName", "bulletImpactNpcShotgun", cr2w, this);
				}
				return _bulletImpactNpcShotgun;
			}
			set
			{
				if (_bulletImpactNpcShotgun == value)
				{
					return;
				}
				_bulletImpactNpcShotgun = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bulletImpactNpcRail")] 
		public CName BulletImpactNpcRail
		{
			get
			{
				if (_bulletImpactNpcRail == null)
				{
					_bulletImpactNpcRail = (CName) CR2WTypeManager.Create("CName", "bulletImpactNpcRail", cr2w, this);
				}
				return _bulletImpactNpcRail;
			}
			set
			{
				if (_bulletImpactNpcRail == value)
				{
					return;
				}
				_bulletImpactNpcRail = value;
				PropertySet(this);
			}
		}

		public audioPhysicalMaterialSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
