using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorFloorTerminalControllerPS : TerminalControllerPS
	{
		private ElevatorFloorSetup _elevatorFloorSetup;
		private CBool _hasDirectInteration;
		private CBool _isElevatorAtThisFloor;

		[Ordinal(113)] 
		[RED("elevatorFloorSetup")] 
		public ElevatorFloorSetup ElevatorFloorSetup
		{
			get
			{
				if (_elevatorFloorSetup == null)
				{
					_elevatorFloorSetup = (ElevatorFloorSetup) CR2WTypeManager.Create("ElevatorFloorSetup", "elevatorFloorSetup", cr2w, this);
				}
				return _elevatorFloorSetup;
			}
			set
			{
				if (_elevatorFloorSetup == value)
				{
					return;
				}
				_elevatorFloorSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("hasDirectInteration")] 
		public CBool HasDirectInteration
		{
			get
			{
				if (_hasDirectInteration == null)
				{
					_hasDirectInteration = (CBool) CR2WTypeManager.Create("Bool", "hasDirectInteration", cr2w, this);
				}
				return _hasDirectInteration;
			}
			set
			{
				if (_hasDirectInteration == value)
				{
					return;
				}
				_hasDirectInteration = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("isElevatorAtThisFloor")] 
		public CBool IsElevatorAtThisFloor
		{
			get
			{
				if (_isElevatorAtThisFloor == null)
				{
					_isElevatorAtThisFloor = (CBool) CR2WTypeManager.Create("Bool", "isElevatorAtThisFloor", cr2w, this);
				}
				return _isElevatorAtThisFloor;
			}
			set
			{
				if (_isElevatorAtThisFloor == value)
				{
					return;
				}
				_isElevatorAtThisFloor = value;
				PropertySet(this);
			}
		}

		public ElevatorFloorTerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
