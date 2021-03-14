using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class speedometerLogicController : IVehicleModuleController
	{
		private inkTextWidgetReference _speedTextWidget;
		private CUInt32 _speedBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private wCHandle<vehicleBaseObject> _vehicle;

		[Ordinal(1)] 
		[RED("speedTextWidget")] 
		public inkTextWidgetReference SpeedTextWidget
		{
			get
			{
				if (_speedTextWidget == null)
				{
					_speedTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "speedTextWidget", cr2w, this);
				}
				return _speedTextWidget;
			}
			set
			{
				if (_speedTextWidget == value)
				{
					return;
				}
				_speedTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		public speedometerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
