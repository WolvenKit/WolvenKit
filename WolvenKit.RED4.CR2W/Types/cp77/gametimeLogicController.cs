using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gametimeLogicController : IVehicleModuleController
	{
		private inkTextWidgetReference _gametimeTextWidget;
		private CUInt32 _gametimeBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private wCHandle<vehicleBaseObject> _vehicle;
		private wCHandle<vehicleUIGameController> _parent;

		[Ordinal(1)] 
		[RED("gametimeTextWidget")] 
		public inkTextWidgetReference GametimeTextWidget
		{
			get
			{
				if (_gametimeTextWidget == null)
				{
					_gametimeTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "gametimeTextWidget", cr2w, this);
				}
				return _gametimeTextWidget;
			}
			set
			{
				if (_gametimeTextWidget == value)
				{
					return;
				}
				_gametimeTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("gametimeBBConnectionId")] 
		public CUInt32 GametimeBBConnectionId
		{
			get
			{
				if (_gametimeBBConnectionId == null)
				{
					_gametimeBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "gametimeBBConnectionId", cr2w, this);
				}
				return _gametimeBBConnectionId;
			}
			set
			{
				if (_gametimeBBConnectionId == value)
				{
					return;
				}
				_gametimeBBConnectionId = value;
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

		[Ordinal(5)] 
		[RED("parent")] 
		public wCHandle<vehicleUIGameController> Parent
		{
			get
			{
				if (_parent == null)
				{
					_parent = (wCHandle<vehicleUIGameController>) CR2WTypeManager.Create("whandle:vehicleUIGameController", "parent", cr2w, this);
				}
				return _parent;
			}
			set
			{
				if (_parent == value)
				{
					return;
				}
				_parent = value;
				PropertySet(this);
			}
		}

		public gametimeLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
