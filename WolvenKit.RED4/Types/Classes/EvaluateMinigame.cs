using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EvaluateMinigame : redEvent
	{
		[Ordinal(0)] 
		[RED("minigameBB")] 
		public CWeakHandle<gameIBlackboard> MinigameBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(1)] 
		[RED("reward")] 
		public TweakDBID Reward
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("journalEntry")] 
		public CString JournalEntry
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("item")] 
		public gameItemID Item
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(6)] 
		[RED("showPopup")] 
		public CBool ShowPopup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("returnToJournal")] 
		public CBool ReturnToJournal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EvaluateMinigame()
		{
			Item = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
