using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleCollisionMap : audioAudioMetadata
	{
		private CFloat _minImpactVelocityThreshold;
		private CFloat _minRumbleVelocityThreshold;
		private CFloat _rumbleCooldown;
		private CFloat _scrapingMinTangentialVelocityThreshold;
		private CFloat _scrapingMaxCollisionCooldown;
		private CFloat _scrapingMinVehicleUpCollisionContactAngle;
		private CBool _useScrapingMinVehicleUpCollisionContactAngle;
		private CName _explosionEvent;
		private CName _bigFireEvent;
		private CName _engineFireEvent;
		private CName _coolerDamageEvent;
		private CArray<audioVehicleCollisionMapItem> _collisionSettings;

		[Ordinal(1)] 
		[RED("minImpactVelocityThreshold")] 
		public CFloat MinImpactVelocityThreshold
		{
			get
			{
				if (_minImpactVelocityThreshold == null)
				{
					_minImpactVelocityThreshold = (CFloat) CR2WTypeManager.Create("Float", "minImpactVelocityThreshold", cr2w, this);
				}
				return _minImpactVelocityThreshold;
			}
			set
			{
				if (_minImpactVelocityThreshold == value)
				{
					return;
				}
				_minImpactVelocityThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minRumbleVelocityThreshold")] 
		public CFloat MinRumbleVelocityThreshold
		{
			get
			{
				if (_minRumbleVelocityThreshold == null)
				{
					_minRumbleVelocityThreshold = (CFloat) CR2WTypeManager.Create("Float", "minRumbleVelocityThreshold", cr2w, this);
				}
				return _minRumbleVelocityThreshold;
			}
			set
			{
				if (_minRumbleVelocityThreshold == value)
				{
					return;
				}
				_minRumbleVelocityThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rumbleCooldown")] 
		public CFloat RumbleCooldown
		{
			get
			{
				if (_rumbleCooldown == null)
				{
					_rumbleCooldown = (CFloat) CR2WTypeManager.Create("Float", "rumbleCooldown", cr2w, this);
				}
				return _rumbleCooldown;
			}
			set
			{
				if (_rumbleCooldown == value)
				{
					return;
				}
				_rumbleCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("scrapingMinTangentialVelocityThreshold")] 
		public CFloat ScrapingMinTangentialVelocityThreshold
		{
			get
			{
				if (_scrapingMinTangentialVelocityThreshold == null)
				{
					_scrapingMinTangentialVelocityThreshold = (CFloat) CR2WTypeManager.Create("Float", "scrapingMinTangentialVelocityThreshold", cr2w, this);
				}
				return _scrapingMinTangentialVelocityThreshold;
			}
			set
			{
				if (_scrapingMinTangentialVelocityThreshold == value)
				{
					return;
				}
				_scrapingMinTangentialVelocityThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scrapingMaxCollisionCooldown")] 
		public CFloat ScrapingMaxCollisionCooldown
		{
			get
			{
				if (_scrapingMaxCollisionCooldown == null)
				{
					_scrapingMaxCollisionCooldown = (CFloat) CR2WTypeManager.Create("Float", "scrapingMaxCollisionCooldown", cr2w, this);
				}
				return _scrapingMaxCollisionCooldown;
			}
			set
			{
				if (_scrapingMaxCollisionCooldown == value)
				{
					return;
				}
				_scrapingMaxCollisionCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scrapingMinVehicleUpCollisionContactAngle")] 
		public CFloat ScrapingMinVehicleUpCollisionContactAngle
		{
			get
			{
				if (_scrapingMinVehicleUpCollisionContactAngle == null)
				{
					_scrapingMinVehicleUpCollisionContactAngle = (CFloat) CR2WTypeManager.Create("Float", "scrapingMinVehicleUpCollisionContactAngle", cr2w, this);
				}
				return _scrapingMinVehicleUpCollisionContactAngle;
			}
			set
			{
				if (_scrapingMinVehicleUpCollisionContactAngle == value)
				{
					return;
				}
				_scrapingMinVehicleUpCollisionContactAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("useScrapingMinVehicleUpCollisionContactAngle")] 
		public CBool UseScrapingMinVehicleUpCollisionContactAngle
		{
			get
			{
				if (_useScrapingMinVehicleUpCollisionContactAngle == null)
				{
					_useScrapingMinVehicleUpCollisionContactAngle = (CBool) CR2WTypeManager.Create("Bool", "useScrapingMinVehicleUpCollisionContactAngle", cr2w, this);
				}
				return _useScrapingMinVehicleUpCollisionContactAngle;
			}
			set
			{
				if (_useScrapingMinVehicleUpCollisionContactAngle == value)
				{
					return;
				}
				_useScrapingMinVehicleUpCollisionContactAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("explosionEvent")] 
		public CName ExplosionEvent
		{
			get
			{
				if (_explosionEvent == null)
				{
					_explosionEvent = (CName) CR2WTypeManager.Create("CName", "explosionEvent", cr2w, this);
				}
				return _explosionEvent;
			}
			set
			{
				if (_explosionEvent == value)
				{
					return;
				}
				_explosionEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("bigFireEvent")] 
		public CName BigFireEvent
		{
			get
			{
				if (_bigFireEvent == null)
				{
					_bigFireEvent = (CName) CR2WTypeManager.Create("CName", "bigFireEvent", cr2w, this);
				}
				return _bigFireEvent;
			}
			set
			{
				if (_bigFireEvent == value)
				{
					return;
				}
				_bigFireEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("engineFireEvent")] 
		public CName EngineFireEvent
		{
			get
			{
				if (_engineFireEvent == null)
				{
					_engineFireEvent = (CName) CR2WTypeManager.Create("CName", "engineFireEvent", cr2w, this);
				}
				return _engineFireEvent;
			}
			set
			{
				if (_engineFireEvent == value)
				{
					return;
				}
				_engineFireEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("coolerDamageEvent")] 
		public CName CoolerDamageEvent
		{
			get
			{
				if (_coolerDamageEvent == null)
				{
					_coolerDamageEvent = (CName) CR2WTypeManager.Create("CName", "coolerDamageEvent", cr2w, this);
				}
				return _coolerDamageEvent;
			}
			set
			{
				if (_coolerDamageEvent == value)
				{
					return;
				}
				_coolerDamageEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("collisionSettings")] 
		public CArray<audioVehicleCollisionMapItem> CollisionSettings
		{
			get
			{
				if (_collisionSettings == null)
				{
					_collisionSettings = (CArray<audioVehicleCollisionMapItem>) CR2WTypeManager.Create("array:audioVehicleCollisionMapItem", "collisionSettings", cr2w, this);
				}
				return _collisionSettings;
			}
			set
			{
				if (_collisionSettings == value)
				{
					return;
				}
				_collisionSettings = value;
				PropertySet(this);
			}
		}

		public audioVehicleCollisionMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
