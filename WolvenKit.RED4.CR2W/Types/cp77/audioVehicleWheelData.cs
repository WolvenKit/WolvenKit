using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleWheelData : CVariable
	{
		private CArray<CName> _wheelStartEvents;
		private CArray<CName> _wheelStopEvents;
		private CArray<CName> _wheelRegularSuspensionImpacts;
		private CArray<CName> _wheelLandingSuspensionImpacts;
		private CFloat _suspensionPressureMultiplier;
		private CFloat _landingSuspensionPressureMultiplier;
		private CFloat _suspensionPressureLimit;
		private CFloat _minSuspensionPressureThreshold;
		private CFloat _suspensionImpactCooldown;
		private CFloat _minWheelTimeInAirBeforeLanding;

		[Ordinal(0)] 
		[RED("wheelStartEvents")] 
		public CArray<CName> WheelStartEvents
		{
			get
			{
				if (_wheelStartEvents == null)
				{
					_wheelStartEvents = (CArray<CName>) CR2WTypeManager.Create("array:CName", "wheelStartEvents", cr2w, this);
				}
				return _wheelStartEvents;
			}
			set
			{
				if (_wheelStartEvents == value)
				{
					return;
				}
				_wheelStartEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wheelStopEvents")] 
		public CArray<CName> WheelStopEvents
		{
			get
			{
				if (_wheelStopEvents == null)
				{
					_wheelStopEvents = (CArray<CName>) CR2WTypeManager.Create("array:CName", "wheelStopEvents", cr2w, this);
				}
				return _wheelStopEvents;
			}
			set
			{
				if (_wheelStopEvents == value)
				{
					return;
				}
				_wheelStopEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("wheelRegularSuspensionImpacts")] 
		public CArray<CName> WheelRegularSuspensionImpacts
		{
			get
			{
				if (_wheelRegularSuspensionImpacts == null)
				{
					_wheelRegularSuspensionImpacts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "wheelRegularSuspensionImpacts", cr2w, this);
				}
				return _wheelRegularSuspensionImpacts;
			}
			set
			{
				if (_wheelRegularSuspensionImpacts == value)
				{
					return;
				}
				_wheelRegularSuspensionImpacts = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("wheelLandingSuspensionImpacts")] 
		public CArray<CName> WheelLandingSuspensionImpacts
		{
			get
			{
				if (_wheelLandingSuspensionImpacts == null)
				{
					_wheelLandingSuspensionImpacts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "wheelLandingSuspensionImpacts", cr2w, this);
				}
				return _wheelLandingSuspensionImpacts;
			}
			set
			{
				if (_wheelLandingSuspensionImpacts == value)
				{
					return;
				}
				_wheelLandingSuspensionImpacts = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("suspensionPressureMultiplier")] 
		public CFloat SuspensionPressureMultiplier
		{
			get
			{
				if (_suspensionPressureMultiplier == null)
				{
					_suspensionPressureMultiplier = (CFloat) CR2WTypeManager.Create("Float", "suspensionPressureMultiplier", cr2w, this);
				}
				return _suspensionPressureMultiplier;
			}
			set
			{
				if (_suspensionPressureMultiplier == value)
				{
					return;
				}
				_suspensionPressureMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("landingSuspensionPressureMultiplier")] 
		public CFloat LandingSuspensionPressureMultiplier
		{
			get
			{
				if (_landingSuspensionPressureMultiplier == null)
				{
					_landingSuspensionPressureMultiplier = (CFloat) CR2WTypeManager.Create("Float", "landingSuspensionPressureMultiplier", cr2w, this);
				}
				return _landingSuspensionPressureMultiplier;
			}
			set
			{
				if (_landingSuspensionPressureMultiplier == value)
				{
					return;
				}
				_landingSuspensionPressureMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("suspensionPressureLimit")] 
		public CFloat SuspensionPressureLimit
		{
			get
			{
				if (_suspensionPressureLimit == null)
				{
					_suspensionPressureLimit = (CFloat) CR2WTypeManager.Create("Float", "suspensionPressureLimit", cr2w, this);
				}
				return _suspensionPressureLimit;
			}
			set
			{
				if (_suspensionPressureLimit == value)
				{
					return;
				}
				_suspensionPressureLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("minSuspensionPressureThreshold")] 
		public CFloat MinSuspensionPressureThreshold
		{
			get
			{
				if (_minSuspensionPressureThreshold == null)
				{
					_minSuspensionPressureThreshold = (CFloat) CR2WTypeManager.Create("Float", "minSuspensionPressureThreshold", cr2w, this);
				}
				return _minSuspensionPressureThreshold;
			}
			set
			{
				if (_minSuspensionPressureThreshold == value)
				{
					return;
				}
				_minSuspensionPressureThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("suspensionImpactCooldown")] 
		public CFloat SuspensionImpactCooldown
		{
			get
			{
				if (_suspensionImpactCooldown == null)
				{
					_suspensionImpactCooldown = (CFloat) CR2WTypeManager.Create("Float", "suspensionImpactCooldown", cr2w, this);
				}
				return _suspensionImpactCooldown;
			}
			set
			{
				if (_suspensionImpactCooldown == value)
				{
					return;
				}
				_suspensionImpactCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("minWheelTimeInAirBeforeLanding")] 
		public CFloat MinWheelTimeInAirBeforeLanding
		{
			get
			{
				if (_minWheelTimeInAirBeforeLanding == null)
				{
					_minWheelTimeInAirBeforeLanding = (CFloat) CR2WTypeManager.Create("Float", "minWheelTimeInAirBeforeLanding", cr2w, this);
				}
				return _minWheelTimeInAirBeforeLanding;
			}
			set
			{
				if (_minWheelTimeInAirBeforeLanding == value)
				{
					return;
				}
				_minWheelTimeInAirBeforeLanding = value;
				PropertySet(this);
			}
		}

		public audioVehicleWheelData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
