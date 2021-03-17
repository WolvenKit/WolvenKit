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
			get => GetProperty(ref _currentlyDebuggedDevice);
			set => SetProperty(ref _currentlyDebuggedDevice, value);
		}

		[Ordinal(1)] 
		[RED("DebuggedEntityIDAsString")] 
		public gamebbScriptID_String DebuggedEntityIDAsString
		{
			get => GetProperty(ref _debuggedEntityIDAsString);
			set => SetProperty(ref _debuggedEntityIDAsString, value);
		}

		public DeviceDebugDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
