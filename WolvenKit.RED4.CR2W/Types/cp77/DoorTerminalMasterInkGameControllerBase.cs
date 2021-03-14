using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorTerminalMasterInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		private CArray<gamePersistentID> _currentlyActiveDevices;

		[Ordinal(18)] 
		[RED("currentlyActiveDevices")] 
		public CArray<gamePersistentID> CurrentlyActiveDevices
		{
			get
			{
				if (_currentlyActiveDevices == null)
				{
					_currentlyActiveDevices = (CArray<gamePersistentID>) CR2WTypeManager.Create("array:gamePersistentID", "currentlyActiveDevices", cr2w, this);
				}
				return _currentlyActiveDevices;
			}
			set
			{
				if (_currentlyActiveDevices == value)
				{
					return;
				}
				_currentlyActiveDevices = value;
				PropertySet(this);
			}
		}

		public DoorTerminalMasterInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
