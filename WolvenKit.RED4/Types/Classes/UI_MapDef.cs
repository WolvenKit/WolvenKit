using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_MapDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("currentLocation")] 
		public gamebbScriptID_String CurrentLocation
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(1)] 
		[RED("currentLocationEnumName")] 
		public gamebbScriptID_String CurrentLocationEnumName
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(2)] 
		[RED("newLocationDiscovered")] 
		public gamebbScriptID_Bool NewLocationDiscovered
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("currentState")] 
		public gamebbScriptID_String CurrentState
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(4)] 
		[RED("minimapLayerHighlightRequest")] 
		public gamebbScriptID_Variant MinimapLayerHighlightRequest
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_MapDef()
		{
			CurrentLocation = new gamebbScriptID_String();
			CurrentLocationEnumName = new gamebbScriptID_String();
			NewLocationDiscovered = new gamebbScriptID_Bool();
			CurrentState = new gamebbScriptID_String();
			MinimapLayerHighlightRequest = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
