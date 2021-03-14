using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorTerminalFakeGameController : DeviceInkGameControllerBase
	{
		private inkCanvasWidgetReference _elevatorTerminalWidget;

		[Ordinal(16)] 
		[RED("elevatorTerminalWidget")] 
		public inkCanvasWidgetReference ElevatorTerminalWidget
		{
			get
			{
				if (_elevatorTerminalWidget == null)
				{
					_elevatorTerminalWidget = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "elevatorTerminalWidget", cr2w, this);
				}
				return _elevatorTerminalWidget;
			}
			set
			{
				if (_elevatorTerminalWidget == value)
				{
					return;
				}
				_elevatorTerminalWidget = value;
				PropertySet(this);
			}
		}

		public ElevatorTerminalFakeGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
