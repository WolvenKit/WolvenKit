using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISquadBlackBoardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _barkPlayed;
		private gamebbScriptID_Bool _lowHealthBarkPlayed;
		private gamebbScriptID_Float _barkPlayedTimeStamp;

		[Ordinal(0)] 
		[RED("BarkPlayed")] 
		public gamebbScriptID_Bool BarkPlayed
		{
			get => GetProperty(ref _barkPlayed);
			set => SetProperty(ref _barkPlayed, value);
		}

		[Ordinal(1)] 
		[RED("LowHealthBarkPlayed")] 
		public gamebbScriptID_Bool LowHealthBarkPlayed
		{
			get => GetProperty(ref _lowHealthBarkPlayed);
			set => SetProperty(ref _lowHealthBarkPlayed, value);
		}

		[Ordinal(2)] 
		[RED("BarkPlayedTimeStamp")] 
		public gamebbScriptID_Float BarkPlayedTimeStamp
		{
			get => GetProperty(ref _barkPlayedTimeStamp);
			set => SetProperty(ref _barkPlayedTimeStamp, value);
		}
	}
}
