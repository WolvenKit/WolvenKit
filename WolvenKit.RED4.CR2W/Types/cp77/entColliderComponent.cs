using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entColliderComponent : entIPlacedComponent
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
			get
			{
				if (_colliders == null)
				{
					_colliders = (CArray<CHandle<physicsICollider>>) CR2WTypeManager.Create("array:handle:physicsICollider", "colliders", cr2w, this);
				}
				return _colliders;
			}
			set
			{
				if (_colliders == value)
				{
					return;
				}
				_colliders = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("shapes")] 
		public CArray<CHandle<entColliderComponentShape>> Shapes
		{
			get
			{
				if (_shapes == null)
				{
					_shapes = (CArray<CHandle<entColliderComponentShape>>) CR2WTypeManager.Create("array:handle:entColliderComponentShape", "shapes", cr2w, this);
				}
				return _shapes;
			}
			set
			{
				if (_shapes == value)
				{
					return;
				}
				_shapes = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get
			{
				if (_simulationType == null)
				{
					_simulationType = (CEnum<physicsSimulationType>) CR2WTypeManager.Create("physicsSimulationType", "simulationType", cr2w, this);
				}
				return _simulationType;
			}
			set
			{
				if (_simulationType == value)
				{
					return;
				}
				_simulationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get
			{
				if (_startInactive == null)
				{
					_startInactive = (CBool) CR2WTypeManager.Create("Bool", "startInactive", cr2w, this);
				}
				return _startInactive;
			}
			set
			{
				if (_startInactive == value)
				{
					return;
				}
				_startInactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("useCCD")] 
		public CBool UseCCD
		{
			get
			{
				if (_useCCD == null)
				{
					_useCCD = (CBool) CR2WTypeManager.Create("Bool", "useCCD", cr2w, this);
				}
				return _useCCD;
			}
			set
			{
				if (_useCCD == value)
				{
					return;
				}
				_useCCD = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("sendOnStoppedMovingEvents")] 
		public CBool SendOnStoppedMovingEvents
		{
			get
			{
				if (_sendOnStoppedMovingEvents == null)
				{
					_sendOnStoppedMovingEvents = (CBool) CR2WTypeManager.Create("Bool", "sendOnStoppedMovingEvents", cr2w, this);
				}
				return _sendOnStoppedMovingEvents;
			}
			set
			{
				if (_sendOnStoppedMovingEvents == value)
				{
					return;
				}
				_sendOnStoppedMovingEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("massOverride")] 
		public CFloat MassOverride
		{
			get
			{
				if (_massOverride == null)
				{
					_massOverride = (CFloat) CR2WTypeManager.Create("Float", "massOverride", cr2w, this);
				}
				return _massOverride;
			}
			set
			{
				if (_massOverride == value)
				{
					return;
				}
				_massOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("volume")] 
		public CFloat Volume
		{
			get
			{
				if (_volume == null)
				{
					_volume = (CFloat) CR2WTypeManager.Create("Float", "volume", cr2w, this);
				}
				return _volume;
			}
			set
			{
				if (_volume == value)
				{
					return;
				}
				_volume = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get
			{
				if (_mass == null)
				{
					_mass = (CFloat) CR2WTypeManager.Create("Float", "mass", cr2w, this);
				}
				return _mass;
			}
			set
			{
				if (_mass == value)
				{
					return;
				}
				_mass = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("inertia")] 
		public Vector3 Inertia
		{
			get
			{
				if (_inertia == null)
				{
					_inertia = (Vector3) CR2WTypeManager.Create("Vector3", "inertia", cr2w, this);
				}
				return _inertia;
			}
			set
			{
				if (_inertia == value)
				{
					return;
				}
				_inertia = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("comOffset")] 
		public Transform ComOffset
		{
			get
			{
				if (_comOffset == null)
				{
					_comOffset = (Transform) CR2WTypeManager.Create("Transform", "comOffset", cr2w, this);
				}
				return _comOffset;
			}
			set
			{
				if (_comOffset == value)
				{
					return;
				}
				_comOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("dynamicTrafficSetting")] 
		public TrafficGenDynamicTrafficSetting DynamicTrafficSetting
		{
			get
			{
				if (_dynamicTrafficSetting == null)
				{
					_dynamicTrafficSetting = (TrafficGenDynamicTrafficSetting) CR2WTypeManager.Create("TrafficGenDynamicTrafficSetting", "dynamicTrafficSetting", cr2w, this);
				}
				return _dynamicTrafficSetting;
			}
			set
			{
				if (_dynamicTrafficSetting == value)
				{
					return;
				}
				_dynamicTrafficSetting = value;
				PropertySet(this);
			}
		}

		public entColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
