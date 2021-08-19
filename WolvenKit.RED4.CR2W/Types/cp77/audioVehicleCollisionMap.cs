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
		private CName _interiorCollisionEvent;
		private CArray<audioVehicleCollisionMapItem> _collisionSettings;

		[Ordinal(1)] 
		[RED("minImpactVelocityThreshold")] 
		public CFloat MinImpactVelocityThreshold
		{
			get => GetProperty(ref _minImpactVelocityThreshold);
			set => SetProperty(ref _minImpactVelocityThreshold, value);
		}

		[Ordinal(2)] 
		[RED("minRumbleVelocityThreshold")] 
		public CFloat MinRumbleVelocityThreshold
		{
			get => GetProperty(ref _minRumbleVelocityThreshold);
			set => SetProperty(ref _minRumbleVelocityThreshold, value);
		}

		[Ordinal(3)] 
		[RED("rumbleCooldown")] 
		public CFloat RumbleCooldown
		{
			get => GetProperty(ref _rumbleCooldown);
			set => SetProperty(ref _rumbleCooldown, value);
		}

		[Ordinal(4)] 
		[RED("scrapingMinTangentialVelocityThreshold")] 
		public CFloat ScrapingMinTangentialVelocityThreshold
		{
			get => GetProperty(ref _scrapingMinTangentialVelocityThreshold);
			set => SetProperty(ref _scrapingMinTangentialVelocityThreshold, value);
		}

		[Ordinal(5)] 
		[RED("scrapingMaxCollisionCooldown")] 
		public CFloat ScrapingMaxCollisionCooldown
		{
			get => GetProperty(ref _scrapingMaxCollisionCooldown);
			set => SetProperty(ref _scrapingMaxCollisionCooldown, value);
		}

		[Ordinal(6)] 
		[RED("scrapingMinVehicleUpCollisionContactAngle")] 
		public CFloat ScrapingMinVehicleUpCollisionContactAngle
		{
			get => GetProperty(ref _scrapingMinVehicleUpCollisionContactAngle);
			set => SetProperty(ref _scrapingMinVehicleUpCollisionContactAngle, value);
		}

		[Ordinal(7)] 
		[RED("useScrapingMinVehicleUpCollisionContactAngle")] 
		public CBool UseScrapingMinVehicleUpCollisionContactAngle
		{
			get => GetProperty(ref _useScrapingMinVehicleUpCollisionContactAngle);
			set => SetProperty(ref _useScrapingMinVehicleUpCollisionContactAngle, value);
		}

		[Ordinal(8)] 
		[RED("explosionEvent")] 
		public CName ExplosionEvent
		{
			get => GetProperty(ref _explosionEvent);
			set => SetProperty(ref _explosionEvent, value);
		}

		[Ordinal(9)] 
		[RED("bigFireEvent")] 
		public CName BigFireEvent
		{
			get => GetProperty(ref _bigFireEvent);
			set => SetProperty(ref _bigFireEvent, value);
		}

		[Ordinal(10)] 
		[RED("engineFireEvent")] 
		public CName EngineFireEvent
		{
			get => GetProperty(ref _engineFireEvent);
			set => SetProperty(ref _engineFireEvent, value);
		}

		[Ordinal(11)] 
		[RED("coolerDamageEvent")] 
		public CName CoolerDamageEvent
		{
			get => GetProperty(ref _coolerDamageEvent);
			set => SetProperty(ref _coolerDamageEvent, value);
		}

		[Ordinal(12)] 
		[RED("interiorCollisionEvent")] 
		public CName InteriorCollisionEvent
		{
			get => GetProperty(ref _interiorCollisionEvent);
			set => SetProperty(ref _interiorCollisionEvent, value);
		}

		[Ordinal(13)] 
		[RED("collisionSettings")] 
		public CArray<audioVehicleCollisionMapItem> CollisionSettings
		{
			get => GetProperty(ref _collisionSettings);
			set => SetProperty(ref _collisionSettings, value);
		}

		public audioVehicleCollisionMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
