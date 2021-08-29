using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entColliderComponent : entIPlacedComponent
	{
		private CArray<CHandle<physicsICollider>> _colliders;
		private CArray<CHandle<entColliderComponentShape>> _shapes;
		private CEnum<physicsSimulationType> _simulationType;
		private CBool _startInactive;
		private CBool _useCCD;
		private CBool _sendOnStoppedMovingEvents;
		private CFloat _massOverride;
		private CFloat _volume;
		private CFloat _mass;
		private Vector3 _inertia;
		private Transform _comOffset;
		private CHandle<physicsFilterData> _filterData;
		private CBool _isEnabled;
		private TrafficGenDynamicTrafficSetting _dynamicTrafficSetting;

		[Ordinal(5)] 
		[RED("colliders")] 
		public CArray<CHandle<physicsICollider>> Colliders
		{
			get => GetProperty(ref _colliders);
			set => SetProperty(ref _colliders, value);
		}

		[Ordinal(6)] 
		[RED("shapes")] 
		public CArray<CHandle<entColliderComponentShape>> Shapes
		{
			get => GetProperty(ref _shapes);
			set => SetProperty(ref _shapes, value);
		}

		[Ordinal(7)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetProperty(ref _simulationType);
			set => SetProperty(ref _simulationType, value);
		}

		[Ordinal(8)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetProperty(ref _startInactive);
			set => SetProperty(ref _startInactive, value);
		}

		[Ordinal(9)] 
		[RED("useCCD")] 
		public CBool UseCCD
		{
			get => GetProperty(ref _useCCD);
			set => SetProperty(ref _useCCD, value);
		}

		[Ordinal(10)] 
		[RED("sendOnStoppedMovingEvents")] 
		public CBool SendOnStoppedMovingEvents
		{
			get => GetProperty(ref _sendOnStoppedMovingEvents);
			set => SetProperty(ref _sendOnStoppedMovingEvents, value);
		}

		[Ordinal(11)] 
		[RED("massOverride")] 
		public CFloat MassOverride
		{
			get => GetProperty(ref _massOverride);
			set => SetProperty(ref _massOverride, value);
		}

		[Ordinal(12)] 
		[RED("volume")] 
		public CFloat Volume
		{
			get => GetProperty(ref _volume);
			set => SetProperty(ref _volume, value);
		}

		[Ordinal(13)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(14)] 
		[RED("inertia")] 
		public Vector3 Inertia
		{
			get => GetProperty(ref _inertia);
			set => SetProperty(ref _inertia, value);
		}

		[Ordinal(15)] 
		[RED("comOffset")] 
		public Transform ComOffset
		{
			get => GetProperty(ref _comOffset);
			set => SetProperty(ref _comOffset, value);
		}

		[Ordinal(16)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(17)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(18)] 
		[RED("dynamicTrafficSetting")] 
		public TrafficGenDynamicTrafficSetting DynamicTrafficSetting
		{
			get => GetProperty(ref _dynamicTrafficSetting);
			set => SetProperty(ref _dynamicTrafficSetting, value);
		}
	}
}
