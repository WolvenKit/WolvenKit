using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITrackedLocation : RedBaseClass
	{
		private AILocationInformation _lastKnown;
		private AILocationInformation _location;
		private AILocationInformation _sharedLocation;
		private CWeakHandle<entEntity> _entity;
		private CFloat _accuracy;
		private CFloat _sharedAccuracy;
		private CFloat _sharedTimeDelay;
		private CFloat _threat;
		private Vector4 _speed;
		private CBool _visible;
		private CBool _invalidExpectation;
		private CEnum<AITrackedStatusType> _status;
		private AILocationInformation _sharedLastKnown;

		[Ordinal(0)] 
		[RED("lastKnown")] 
		public AILocationInformation LastKnown
		{
			get => GetProperty(ref _lastKnown);
			set => SetProperty(ref _lastKnown, value);
		}

		[Ordinal(1)] 
		[RED("location")] 
		public AILocationInformation Location
		{
			get => GetProperty(ref _location);
			set => SetProperty(ref _location, value);
		}

		[Ordinal(2)] 
		[RED("sharedLocation")] 
		public AILocationInformation SharedLocation
		{
			get => GetProperty(ref _sharedLocation);
			set => SetProperty(ref _sharedLocation, value);
		}

		[Ordinal(3)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(4)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get => GetProperty(ref _accuracy);
			set => SetProperty(ref _accuracy, value);
		}

		[Ordinal(5)] 
		[RED("sharedAccuracy")] 
		public CFloat SharedAccuracy
		{
			get => GetProperty(ref _sharedAccuracy);
			set => SetProperty(ref _sharedAccuracy, value);
		}

		[Ordinal(6)] 
		[RED("sharedTimeDelay")] 
		public CFloat SharedTimeDelay
		{
			get => GetProperty(ref _sharedTimeDelay);
			set => SetProperty(ref _sharedTimeDelay, value);
		}

		[Ordinal(7)] 
		[RED("threat")] 
		public CFloat Threat
		{
			get => GetProperty(ref _threat);
			set => SetProperty(ref _threat, value);
		}

		[Ordinal(8)] 
		[RED("speed")] 
		public Vector4 Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(9)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		[Ordinal(10)] 
		[RED("invalidExpectation")] 
		public CBool InvalidExpectation
		{
			get => GetProperty(ref _invalidExpectation);
			set => SetProperty(ref _invalidExpectation, value);
		}

		[Ordinal(11)] 
		[RED("status")] 
		public CEnum<AITrackedStatusType> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(12)] 
		[RED("sharedLastKnown")] 
		public AILocationInformation SharedLastKnown
		{
			get => GetProperty(ref _sharedLastKnown);
			set => SetProperty(ref _sharedLastKnown, value);
		}

		public AITrackedLocation()
		{
			_accuracy = 1.000000F;
			_sharedAccuracy = 1.000000F;
		}
	}
}
