using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_MapDef : gamebbScriptDefinition
	{
		private gamebbScriptID_String _currentLocation;
		private gamebbScriptID_String _currentLocationEnumName;
		private gamebbScriptID_Bool _newLocationDiscovered;
		private gamebbScriptID_String _currentState;

		[Ordinal(0)] 
		[RED("currentLocation")] 
		public gamebbScriptID_String CurrentLocation
		{
			get
			{
				if (_currentLocation == null)
				{
					_currentLocation = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "currentLocation", cr2w, this);
				}
				return _currentLocation;
			}
			set
			{
				if (_currentLocation == value)
				{
					return;
				}
				_currentLocation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentLocationEnumName")] 
		public gamebbScriptID_String CurrentLocationEnumName
		{
			get
			{
				if (_currentLocationEnumName == null)
				{
					_currentLocationEnumName = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "currentLocationEnumName", cr2w, this);
				}
				return _currentLocationEnumName;
			}
			set
			{
				if (_currentLocationEnumName == value)
				{
					return;
				}
				_currentLocationEnumName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("newLocationDiscovered")] 
		public gamebbScriptID_Bool NewLocationDiscovered
		{
			get
			{
				if (_newLocationDiscovered == null)
				{
					_newLocationDiscovered = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "newLocationDiscovered", cr2w, this);
				}
				return _newLocationDiscovered;
			}
			set
			{
				if (_newLocationDiscovered == value)
				{
					return;
				}
				_newLocationDiscovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentState")] 
		public gamebbScriptID_String CurrentState
		{
			get
			{
				if (_currentState == null)
				{
					_currentState = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "currentState", cr2w, this);
				}
				return _currentState;
			}
			set
			{
				if (_currentState == value)
				{
					return;
				}
				_currentState = value;
				PropertySet(this);
			}
		}

		public UI_MapDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
