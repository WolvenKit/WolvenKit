using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceBaseBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ActionWidgetsData")] 
		public gamebbScriptID_Variant ActionWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("DeviceWidgetsData")] 
		public gamebbScriptID_Variant DeviceWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("UIupdate")] 
		public gamebbScriptID_Bool UIupdate
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("BreadCrumbElement")] 
		public gamebbScriptID_Variant BreadCrumbElement
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(4)] 
		[RED("GlitchData")] 
		public gamebbScriptID_Variant GlitchData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("UI_InteractivityBlocked")] 
		public gamebbScriptID_Bool UI_InteractivityBlocked
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("IsInvestigated")] 
		public gamebbScriptID_Bool IsInvestigated
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public DeviceBaseBlackboardDef()
		{
			ActionWidgetsData = new gamebbScriptID_Variant();
			DeviceWidgetsData = new gamebbScriptID_Variant();
			UIupdate = new gamebbScriptID_Bool();
			BreadCrumbElement = new gamebbScriptID_Variant();
			GlitchData = new gamebbScriptID_Variant();
			UI_InteractivityBlocked = new gamebbScriptID_Bool();
			IsInvestigated = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
