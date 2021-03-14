using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CarHotkeyController : GenericHotkeyController
	{
		private inkImageWidgetReference _carIconSlot;
		private wCHandle<gameVehicleSystem> _vehicleSystem;
		private CHandle<gameIBlackboard> _psmBB;
		private CUInt32 _bbListener;

		[Ordinal(19)] 
		[RED("carIconSlot")] 
		public inkImageWidgetReference CarIconSlot
		{
			get
			{
				if (_carIconSlot == null)
				{
					_carIconSlot = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "carIconSlot", cr2w, this);
				}
				return _carIconSlot;
			}
			set
			{
				if (_carIconSlot == value)
				{
					return;
				}
				_carIconSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("vehicleSystem")] 
		public wCHandle<gameVehicleSystem> VehicleSystem
		{
			get
			{
				if (_vehicleSystem == null)
				{
					_vehicleSystem = (wCHandle<gameVehicleSystem>) CR2WTypeManager.Create("whandle:gameVehicleSystem", "vehicleSystem", cr2w, this);
				}
				return _vehicleSystem;
			}
			set
			{
				if (_vehicleSystem == value)
				{
					return;
				}
				_vehicleSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("psmBB")] 
		public CHandle<gameIBlackboard> PsmBB
		{
			get
			{
				if (_psmBB == null)
				{
					_psmBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "psmBB", cr2w, this);
				}
				return _psmBB;
			}
			set
			{
				if (_psmBB == value)
				{
					return;
				}
				_psmBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("bbListener")] 
		public CUInt32 BbListener
		{
			get
			{
				if (_bbListener == null)
				{
					_bbListener = (CUInt32) CR2WTypeManager.Create("Uint32", "bbListener", cr2w, this);
				}
				return _bbListener;
			}
			set
			{
				if (_bbListener == value)
				{
					return;
				}
				_bbListener = value;
				PropertySet(this);
			}
		}

		public CarHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
