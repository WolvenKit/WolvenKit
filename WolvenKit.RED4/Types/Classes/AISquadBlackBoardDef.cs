using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AISquadBlackBoardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("BarkPlayed")] 
		public gamebbScriptID_Bool BarkPlayed
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("LowHealthBarkPlayed")] 
		public gamebbScriptID_Bool LowHealthBarkPlayed
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("BarkPlayedTimeStamp")] 
		public gamebbScriptID_Float BarkPlayedTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public AISquadBlackBoardDef()
		{
			BarkPlayed = new();
			LowHealthBarkPlayed = new();
			BarkPlayedTimeStamp = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
