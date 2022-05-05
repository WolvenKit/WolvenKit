using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_PlayerBioMonitorDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("PlayerStatsInfo")] 
		public gamebbScriptID_Variant PlayerStatsInfo
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("BuffsList")] 
		public gamebbScriptID_Variant BuffsList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("DebuffsList")] 
		public gamebbScriptID_Variant DebuffsList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("Cooldowns")] 
		public gamebbScriptID_Variant Cooldowns
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(4)] 
		[RED("AdrenalineBar")] 
		public gamebbScriptID_Float AdrenalineBar
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(5)] 
		[RED("CurrentNetrunnerCharges")] 
		public gamebbScriptID_Int32 CurrentNetrunnerCharges
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(6)] 
		[RED("NetworkChargesCapacity")] 
		public gamebbScriptID_Int32 NetworkChargesCapacity
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(7)] 
		[RED("NetworkName")] 
		public gamebbScriptID_CName NetworkName
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(8)] 
		[RED("MemoryPercent")] 
		public gamebbScriptID_Float MemoryPercent
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public UI_PlayerBioMonitorDef()
		{
			PlayerStatsInfo = new();
			BuffsList = new();
			DebuffsList = new();
			Cooldowns = new();
			AdrenalineBar = new();
			CurrentNetrunnerCharges = new();
			NetworkChargesCapacity = new();
			NetworkName = new();
			MemoryPercent = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
