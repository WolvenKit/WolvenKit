using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_PlayerBioMonitorDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _playerStatsInfo;
		private gamebbScriptID_Variant _buffsList;
		private gamebbScriptID_Variant _debuffsList;
		private gamebbScriptID_Variant _cooldowns;
		private gamebbScriptID_Float _adrenalineBar;
		private gamebbScriptID_Int32 _currentNetrunnerCharges;
		private gamebbScriptID_Int32 _networkChargesCapacity;
		private gamebbScriptID_CName _networkName;
		private gamebbScriptID_Float _memoryPercent;

		[Ordinal(0)] 
		[RED("PlayerStatsInfo")] 
		public gamebbScriptID_Variant PlayerStatsInfo
		{
			get => GetProperty(ref _playerStatsInfo);
			set => SetProperty(ref _playerStatsInfo, value);
		}

		[Ordinal(1)] 
		[RED("BuffsList")] 
		public gamebbScriptID_Variant BuffsList
		{
			get => GetProperty(ref _buffsList);
			set => SetProperty(ref _buffsList, value);
		}

		[Ordinal(2)] 
		[RED("DebuffsList")] 
		public gamebbScriptID_Variant DebuffsList
		{
			get => GetProperty(ref _debuffsList);
			set => SetProperty(ref _debuffsList, value);
		}

		[Ordinal(3)] 
		[RED("Cooldowns")] 
		public gamebbScriptID_Variant Cooldowns
		{
			get => GetProperty(ref _cooldowns);
			set => SetProperty(ref _cooldowns, value);
		}

		[Ordinal(4)] 
		[RED("AdrenalineBar")] 
		public gamebbScriptID_Float AdrenalineBar
		{
			get => GetProperty(ref _adrenalineBar);
			set => SetProperty(ref _adrenalineBar, value);
		}

		[Ordinal(5)] 
		[RED("CurrentNetrunnerCharges")] 
		public gamebbScriptID_Int32 CurrentNetrunnerCharges
		{
			get => GetProperty(ref _currentNetrunnerCharges);
			set => SetProperty(ref _currentNetrunnerCharges, value);
		}

		[Ordinal(6)] 
		[RED("NetworkChargesCapacity")] 
		public gamebbScriptID_Int32 NetworkChargesCapacity
		{
			get => GetProperty(ref _networkChargesCapacity);
			set => SetProperty(ref _networkChargesCapacity, value);
		}

		[Ordinal(7)] 
		[RED("NetworkName")] 
		public gamebbScriptID_CName NetworkName
		{
			get => GetProperty(ref _networkName);
			set => SetProperty(ref _networkName, value);
		}

		[Ordinal(8)] 
		[RED("MemoryPercent")] 
		public gamebbScriptID_Float MemoryPercent
		{
			get => GetProperty(ref _memoryPercent);
			set => SetProperty(ref _memoryPercent, value);
		}

		public UI_PlayerBioMonitorDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
