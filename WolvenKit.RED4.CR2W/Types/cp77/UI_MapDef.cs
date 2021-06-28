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
			get => GetProperty(ref _currentLocation);
			set => SetProperty(ref _currentLocation, value);
		}

		[Ordinal(1)] 
		[RED("currentLocationEnumName")] 
		public gamebbScriptID_String CurrentLocationEnumName
		{
			get => GetProperty(ref _currentLocationEnumName);
			set => SetProperty(ref _currentLocationEnumName, value);
		}

		[Ordinal(2)] 
		[RED("newLocationDiscovered")] 
		public gamebbScriptID_Bool NewLocationDiscovered
		{
			get => GetProperty(ref _newLocationDiscovered);
			set => SetProperty(ref _newLocationDiscovered, value);
		}

		[Ordinal(3)] 
		[RED("currentState")] 
		public gamebbScriptID_String CurrentState
		{
			get => GetProperty(ref _currentState);
			set => SetProperty(ref _currentState, value);
		}

		public UI_MapDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
