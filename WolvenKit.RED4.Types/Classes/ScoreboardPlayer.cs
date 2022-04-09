using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScoreboardPlayer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("playerName")] 
		public CString PlayerName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("playerScore")] 
		public CInt32 PlayerScore
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ScoreboardPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
