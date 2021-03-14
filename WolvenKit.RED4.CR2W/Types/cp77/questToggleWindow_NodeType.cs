using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleWindow_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CEnum<vehicleEQuestVehicleWindowState> _windowState;
		private CEnum<vehicleEVehicleDoor> _door;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get
			{
				if (_vehicleRef == null)
				{
					_vehicleRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicleRef", cr2w, this);
				}
				return _vehicleRef;
			}
			set
			{
				if (_vehicleRef == value)
				{
					return;
				}
				_vehicleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("windowState")] 
		public CEnum<vehicleEQuestVehicleWindowState> WindowState
		{
			get
			{
				if (_windowState == null)
				{
					_windowState = (CEnum<vehicleEQuestVehicleWindowState>) CR2WTypeManager.Create("vehicleEQuestVehicleWindowState", "windowState", cr2w, this);
				}
				return _windowState;
			}
			set
			{
				if (_windowState == value)
				{
					return;
				}
				_windowState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get
			{
				if (_door == null)
				{
					_door = (CEnum<vehicleEVehicleDoor>) CR2WTypeManager.Create("vehicleEVehicleDoor", "door", cr2w, this);
				}
				return _door;
			}
			set
			{
				if (_door == value)
				{
					return;
				}
				_door = value;
				PropertySet(this);
			}
		}

		public questToggleWindow_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
