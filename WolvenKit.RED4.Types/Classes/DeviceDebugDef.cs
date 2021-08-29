using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceDebugDef : gamebbScriptDefinition
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
	}
}
