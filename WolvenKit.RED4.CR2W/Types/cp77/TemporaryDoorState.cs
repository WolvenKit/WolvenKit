using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporaryDoorState : CVariable
	{
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleVehicleDoorInteractionState> _interactionState;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("interactionState")] 
		public CEnum<vehicleVehicleDoorInteractionState> InteractionState
		{
			get
			{
				if (_interactionState == null)
				{
					_interactionState = (CEnum<vehicleVehicleDoorInteractionState>) CR2WTypeManager.Create("vehicleVehicleDoorInteractionState", "interactionState", cr2w, this);
				}
				return _interactionState;
			}
			set
			{
				if (_interactionState == value)
				{
					return;
				}
				_interactionState = value;
				PropertySet(this);
			}
		}

		public TemporaryDoorState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
