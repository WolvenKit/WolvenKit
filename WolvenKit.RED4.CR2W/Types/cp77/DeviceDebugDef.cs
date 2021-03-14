using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceDebugDef : gamebbScriptDefinition
	{
		private gamebbScriptID_CName _currentlyDebuggedDevice;
		private gamebbScriptID_String _debuggedEntityIDAsString;

		[Ordinal(0)] 
		[RED("CurrentlyDebuggedDevice")] 
		public gamebbScriptID_CName CurrentlyDebuggedDevice
		{
			get
			{
				if (_currentlyDebuggedDevice == null)
				{
					_currentlyDebuggedDevice = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "CurrentlyDebuggedDevice", cr2w, this);
				}
				return _currentlyDebuggedDevice;
			}
			set
			{
				if (_currentlyDebuggedDevice == value)
				{
					return;
				}
				_currentlyDebuggedDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("DebuggedEntityIDAsString")] 
		public gamebbScriptID_String DebuggedEntityIDAsString
		{
			get
			{
				if (_debuggedEntityIDAsString == null)
				{
					_debuggedEntityIDAsString = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "DebuggedEntityIDAsString", cr2w, this);
				}
				return _debuggedEntityIDAsString;
			}
			set
			{
				if (_debuggedEntityIDAsString == value)
				{
					return;
				}
				_debuggedEntityIDAsString = value;
				PropertySet(this);
			}
		}

		public DeviceDebugDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
