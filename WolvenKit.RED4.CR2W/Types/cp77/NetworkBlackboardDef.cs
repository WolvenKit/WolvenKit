using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _minigameDef;
		private gamebbScriptID_String _networkName;
		private gamebbScriptID_Variant _networkTDBID;
		private gamebbScriptID_Int32 _devicesCount;
		private gamebbScriptID_EntityID _deviceID;
		private gamebbScriptID_Bool _officerBreach;
		private gamebbScriptID_Bool _suicideBreach;
		private gamebbScriptID_Bool _remoteBreach;
		private gamebbScriptID_Bool _itemBreach;
		private gamebbScriptID_Int32 _attempt;
		private gamebbScriptID_Variant _selectedMinigameDef;

		[Ordinal(0)] 
		[RED("MinigameDef")] 
		public gamebbScriptID_Variant MinigameDef
		{
			get => GetProperty(ref _minigameDef);
			set => SetProperty(ref _minigameDef, value);
		}

		[Ordinal(1)] 
		[RED("NetworkName")] 
		public gamebbScriptID_String NetworkName
		{
			get => GetProperty(ref _networkName);
			set => SetProperty(ref _networkName, value);
		}

		[Ordinal(2)] 
		[RED("NetworkTDBID")] 
		public gamebbScriptID_Variant NetworkTDBID
		{
			get => GetProperty(ref _networkTDBID);
			set => SetProperty(ref _networkTDBID, value);
		}

		[Ordinal(3)] 
		[RED("DevicesCount")] 
		public gamebbScriptID_Int32 DevicesCount
		{
			get => GetProperty(ref _devicesCount);
			set => SetProperty(ref _devicesCount, value);
		}

		[Ordinal(4)] 
		[RED("DeviceID")] 
		public gamebbScriptID_EntityID DeviceID
		{
			get => GetProperty(ref _deviceID);
			set => SetProperty(ref _deviceID, value);
		}

		[Ordinal(5)] 
		[RED("OfficerBreach")] 
		public gamebbScriptID_Bool OfficerBreach
		{
			get => GetProperty(ref _officerBreach);
			set => SetProperty(ref _officerBreach, value);
		}

		[Ordinal(6)] 
		[RED("SuicideBreach")] 
		public gamebbScriptID_Bool SuicideBreach
		{
			get => GetProperty(ref _suicideBreach);
			set => SetProperty(ref _suicideBreach, value);
		}

		[Ordinal(7)] 
		[RED("RemoteBreach")] 
		public gamebbScriptID_Bool RemoteBreach
		{
			get => GetProperty(ref _remoteBreach);
			set => SetProperty(ref _remoteBreach, value);
		}

		[Ordinal(8)] 
		[RED("ItemBreach")] 
		public gamebbScriptID_Bool ItemBreach
		{
			get => GetProperty(ref _itemBreach);
			set => SetProperty(ref _itemBreach, value);
		}

		[Ordinal(9)] 
		[RED("Attempt")] 
		public gamebbScriptID_Int32 Attempt
		{
			get => GetProperty(ref _attempt);
			set => SetProperty(ref _attempt, value);
		}

		[Ordinal(10)] 
		[RED("SelectedMinigameDef")] 
		public gamebbScriptID_Variant SelectedMinigameDef
		{
			get => GetProperty(ref _selectedMinigameDef);
			set => SetProperty(ref _selectedMinigameDef, value);
		}

		public NetworkBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
