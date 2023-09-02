using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIWorldBoundariesDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("IsPlayerCloseToBoundary")] 
		public gamebbScriptID_Bool IsPlayerCloseToBoundary
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("IsPlayerGoingDeeper")] 
		public gamebbScriptID_Bool IsPlayerGoingDeeper
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UIWorldBoundariesDef()
		{
			IsPlayerCloseToBoundary = new gamebbScriptID_Bool();
			IsPlayerGoingDeeper = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
