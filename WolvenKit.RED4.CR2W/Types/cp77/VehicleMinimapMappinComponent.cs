using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleMinimapMappinComponent : IScriptable
	{
		private wCHandle<MinimapPOIMappinController> _minimapPOIMappinController;
		private CBool _vehicleIsLatestSummoned;
		private entEntityID _vehicleEntityID;
		private CHandle<VehicleSummonDataDef> _vehicleSummonDataDef;
		private CHandle<gameIBlackboard> _vehicleSummonDataBB;
		private CUInt32 _vehicleSummonStateCallback;

		[Ordinal(0)] 
		[RED("minimapPOIMappinController")] 
		public wCHandle<MinimapPOIMappinController> MinimapPOIMappinController
		{
			get
			{
				if (_minimapPOIMappinController == null)
				{
					_minimapPOIMappinController = (wCHandle<MinimapPOIMappinController>) CR2WTypeManager.Create("whandle:MinimapPOIMappinController", "minimapPOIMappinController", cr2w, this);
				}
				return _minimapPOIMappinController;
			}
			set
			{
				if (_minimapPOIMappinController == value)
				{
					return;
				}
				_minimapPOIMappinController = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vehicleIsLatestSummoned")] 
		public CBool VehicleIsLatestSummoned
		{
			get
			{
				if (_vehicleIsLatestSummoned == null)
				{
					_vehicleIsLatestSummoned = (CBool) CR2WTypeManager.Create("Bool", "vehicleIsLatestSummoned", cr2w, this);
				}
				return _vehicleIsLatestSummoned;
			}
			set
			{
				if (_vehicleIsLatestSummoned == value)
				{
					return;
				}
				_vehicleIsLatestSummoned = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vehicleEntityID")] 
		public entEntityID VehicleEntityID
		{
			get
			{
				if (_vehicleEntityID == null)
				{
					_vehicleEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "vehicleEntityID", cr2w, this);
				}
				return _vehicleEntityID;
			}
			set
			{
				if (_vehicleEntityID == value)
				{
					return;
				}
				_vehicleEntityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get
			{
				if (_vehicleSummonDataDef == null)
				{
					_vehicleSummonDataDef = (CHandle<VehicleSummonDataDef>) CR2WTypeManager.Create("handle:VehicleSummonDataDef", "vehicleSummonDataDef", cr2w, this);
				}
				return _vehicleSummonDataDef;
			}
			set
			{
				if (_vehicleSummonDataDef == value)
				{
					return;
				}
				_vehicleSummonDataDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("vehicleSummonDataBB")] 
		public CHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get
			{
				if (_vehicleSummonDataBB == null)
				{
					_vehicleSummonDataBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "vehicleSummonDataBB", cr2w, this);
				}
				return _vehicleSummonDataBB;
			}
			set
			{
				if (_vehicleSummonDataBB == value)
				{
					return;
				}
				_vehicleSummonDataBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("vehicleSummonStateCallback")] 
		public CUInt32 VehicleSummonStateCallback
		{
			get
			{
				if (_vehicleSummonStateCallback == null)
				{
					_vehicleSummonStateCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleSummonStateCallback", cr2w, this);
				}
				return _vehicleSummonStateCallback;
			}
			set
			{
				if (_vehicleSummonStateCallback == value)
				{
					return;
				}
				_vehicleSummonStateCallback = value;
				PropertySet(this);
			}
		}

		public VehicleMinimapMappinComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
