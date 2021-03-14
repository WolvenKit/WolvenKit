using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorTerminalLogicController : DeviceWidgetControllerBase
	{
		private inkFlexWidgetReference _elevatorUpArrowsWidget;
		private inkFlexWidgetReference _elevatorDownArrowsWidget;
		private CEnum<EForcedElevatorArrowsState> _forcedElevatorArrowsState;

		[Ordinal(10)] 
		[RED("elevatorUpArrowsWidget")] 
		public inkFlexWidgetReference ElevatorUpArrowsWidget
		{
			get
			{
				if (_elevatorUpArrowsWidget == null)
				{
					_elevatorUpArrowsWidget = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "elevatorUpArrowsWidget", cr2w, this);
				}
				return _elevatorUpArrowsWidget;
			}
			set
			{
				if (_elevatorUpArrowsWidget == value)
				{
					return;
				}
				_elevatorUpArrowsWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("elevatorDownArrowsWidget")] 
		public inkFlexWidgetReference ElevatorDownArrowsWidget
		{
			get
			{
				if (_elevatorDownArrowsWidget == null)
				{
					_elevatorDownArrowsWidget = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "elevatorDownArrowsWidget", cr2w, this);
				}
				return _elevatorDownArrowsWidget;
			}
			set
			{
				if (_elevatorDownArrowsWidget == value)
				{
					return;
				}
				_elevatorDownArrowsWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("forcedElevatorArrowsState")] 
		public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState
		{
			get
			{
				if (_forcedElevatorArrowsState == null)
				{
					_forcedElevatorArrowsState = (CEnum<EForcedElevatorArrowsState>) CR2WTypeManager.Create("EForcedElevatorArrowsState", "forcedElevatorArrowsState", cr2w, this);
				}
				return _forcedElevatorArrowsState;
			}
			set
			{
				if (_forcedElevatorArrowsState == value)
				{
					return;
				}
				_forcedElevatorArrowsState = value;
				PropertySet(this);
			}
		}

		public ElevatorTerminalLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
