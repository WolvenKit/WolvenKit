using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("MinigameDef")] 
		public gamebbScriptID_Variant MinigameDef
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("NetworkName")] 
		public gamebbScriptID_String NetworkName
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(2)] 
		[RED("NetworkTDBID")] 
		public gamebbScriptID_Variant NetworkTDBID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("DevicesCount")] 
		public gamebbScriptID_Int32 DevicesCount
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("DeviceID")] 
		public gamebbScriptID_EntityID DeviceID
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(5)] 
		[RED("OfficerBreach")] 
		public gamebbScriptID_Bool OfficerBreach
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("SuicideBreach")] 
		public gamebbScriptID_Bool SuicideBreach
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(7)] 
		[RED("RemoteBreach")] 
		public gamebbScriptID_Bool RemoteBreach
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(8)] 
		[RED("ItemBreach")] 
		public gamebbScriptID_Bool ItemBreach
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(9)] 
		[RED("Attempt")] 
		public gamebbScriptID_Int32 Attempt
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(10)] 
		[RED("SelectedMinigameDef")] 
		public gamebbScriptID_Variant SelectedMinigameDef
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(11)] 
		[RED("PersonalLinkStatus")] 
		public gamebbScriptID_Int32 PersonalLinkStatus
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public NetworkBlackboardDef()
		{
			MinigameDef = new gamebbScriptID_Variant();
			NetworkName = new gamebbScriptID_String();
			NetworkTDBID = new gamebbScriptID_Variant();
			DevicesCount = new gamebbScriptID_Int32();
			DeviceID = new gamebbScriptID_EntityID();
			OfficerBreach = new gamebbScriptID_Bool();
			SuicideBreach = new gamebbScriptID_Bool();
			RemoteBreach = new gamebbScriptID_Bool();
			ItemBreach = new gamebbScriptID_Bool();
			Attempt = new gamebbScriptID_Int32();
			SelectedMinigameDef = new gamebbScriptID_Variant();
			PersonalLinkStatus = new gamebbScriptID_Int32();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
