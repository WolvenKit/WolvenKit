using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_String _currentFloor;
		private gamebbScriptID_Bool _isPlayerScanned;
		private gamebbScriptID_Bool _isPaused;

		[Ordinal(7)] 
		[RED("CurrentFloor")] 
		public gamebbScriptID_String CurrentFloor
		{
			get
			{
				if (_currentFloor == null)
				{
					_currentFloor = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "CurrentFloor", cr2w, this);
				}
				return _currentFloor;
			}
			set
			{
				if (_currentFloor == value)
				{
					return;
				}
				_currentFloor = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isPlayerScanned")] 
		public gamebbScriptID_Bool IsPlayerScanned
		{
			get
			{
				if (_isPlayerScanned == null)
				{
					_isPlayerScanned = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "isPlayerScanned", cr2w, this);
				}
				return _isPlayerScanned;
			}
			set
			{
				if (_isPlayerScanned == value)
				{
					return;
				}
				_isPlayerScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isPaused")] 
		public gamebbScriptID_Bool IsPaused
		{
			get
			{
				if (_isPaused == null)
				{
					_isPaused = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "isPaused", cr2w, this);
				}
				return _isPaused;
			}
			set
			{
				if (_isPaused == value)
				{
					return;
				}
				_isPaused = value;
				PropertySet(this);
			}
		}

		public ElevatorDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
