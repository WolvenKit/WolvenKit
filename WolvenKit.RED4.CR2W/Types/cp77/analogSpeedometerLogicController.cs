using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class analogSpeedometerLogicController : IVehicleModuleController
	{
		private inkWidgetReference _analogSpeedNeedleWidget;
		private CFloat _analogSpeedNeedleMinRotation;
		private CFloat _analogSpeedNeedleMaxRotation;
		private CFloat _analogSpeedNeedleMaxValue;
		private CUInt32 _speedBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private wCHandle<vehicleBaseObject> _vehicle;

		[Ordinal(1)] 
		[RED("analogSpeedNeedleWidget")] 
		public inkWidgetReference AnalogSpeedNeedleWidget
		{
			get
			{
				if (_analogSpeedNeedleWidget == null)
				{
					_analogSpeedNeedleWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "analogSpeedNeedleWidget", cr2w, this);
				}
				return _analogSpeedNeedleWidget;
			}
			set
			{
				if (_analogSpeedNeedleWidget == value)
				{
					return;
				}
				_analogSpeedNeedleWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("analogSpeedNeedleMinRotation")] 
		public CFloat AnalogSpeedNeedleMinRotation
		{
			get
			{
				if (_analogSpeedNeedleMinRotation == null)
				{
					_analogSpeedNeedleMinRotation = (CFloat) CR2WTypeManager.Create("Float", "analogSpeedNeedleMinRotation", cr2w, this);
				}
				return _analogSpeedNeedleMinRotation;
			}
			set
			{
				if (_analogSpeedNeedleMinRotation == value)
				{
					return;
				}
				_analogSpeedNeedleMinRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("analogSpeedNeedleMaxRotation")] 
		public CFloat AnalogSpeedNeedleMaxRotation
		{
			get
			{
				if (_analogSpeedNeedleMaxRotation == null)
				{
					_analogSpeedNeedleMaxRotation = (CFloat) CR2WTypeManager.Create("Float", "analogSpeedNeedleMaxRotation", cr2w, this);
				}
				return _analogSpeedNeedleMaxRotation;
			}
			set
			{
				if (_analogSpeedNeedleMaxRotation == value)
				{
					return;
				}
				_analogSpeedNeedleMaxRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("analogSpeedNeedleMaxValue")] 
		public CFloat AnalogSpeedNeedleMaxValue
		{
			get
			{
				if (_analogSpeedNeedleMaxValue == null)
				{
					_analogSpeedNeedleMaxValue = (CFloat) CR2WTypeManager.Create("Float", "analogSpeedNeedleMaxValue", cr2w, this);
				}
				return _analogSpeedNeedleMaxValue;
			}
			set
			{
				if (_analogSpeedNeedleMaxValue == value)
				{
					return;
				}
				_analogSpeedNeedleMaxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("speedBBConnectionId")] 
		public CUInt32 SpeedBBConnectionId
		{
			get
			{
				if (_speedBBConnectionId == null)
				{
					_speedBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "speedBBConnectionId", cr2w, this);
				}
				return _speedBBConnectionId;
			}
			set
			{
				if (_speedBBConnectionId == value)
				{
					return;
				}
				_speedBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("vehBB")] 
		public wCHandle<gameIBlackboard> VehBB
		{
			get
			{
				if (_vehBB == null)
				{
					_vehBB = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "vehBB", cr2w, this);
				}
				return _vehBB;
			}
			set
			{
				if (_vehBB == value)
				{
					return;
				}
				_vehBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "vehicle", cr2w, this);
				}
				return _vehicle;
			}
			set
			{
				if (_vehicle == value)
				{
					return;
				}
				_vehicle = value;
				PropertySet(this);
			}
		}

		public analogSpeedometerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
