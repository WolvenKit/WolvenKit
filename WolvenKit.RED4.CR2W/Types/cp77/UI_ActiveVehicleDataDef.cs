using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ActiveVehicleDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _vehPlayerStateData;
		private gamebbScriptID_Bool _isPlayerMounted;
		private gamebbScriptID_Bool _isTPPCameraOn;
		private gamebbScriptID_Int32 _positionInRace;

		[Ordinal(0)] 
		[RED("VehPlayerStateData")] 
		public gamebbScriptID_Variant VehPlayerStateData
		{
			get => GetProperty(ref _vehPlayerStateData);
			set => SetProperty(ref _vehPlayerStateData, value);
		}

		[Ordinal(1)] 
		[RED("IsPlayerMounted")] 
		public gamebbScriptID_Bool IsPlayerMounted
		{
			get => GetProperty(ref _isPlayerMounted);
			set => SetProperty(ref _isPlayerMounted, value);
		}

		[Ordinal(2)] 
		[RED("IsTPPCameraOn")] 
		public gamebbScriptID_Bool IsTPPCameraOn
		{
			get => GetProperty(ref _isTPPCameraOn);
			set => SetProperty(ref _isTPPCameraOn, value);
		}

		[Ordinal(3)] 
		[RED("PositionInRace")] 
		public gamebbScriptID_Int32 PositionInRace
		{
			get => GetProperty(ref _positionInRace);
			set => SetProperty(ref _positionInRace, value);
		}

		public UI_ActiveVehicleDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
