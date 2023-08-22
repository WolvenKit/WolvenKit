using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackingMinigameDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("MinigameDefaults")] 
		public gamebbScriptID_Variant MinigameDefaults
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("NextMinigameData")] 
		public gamebbScriptID_Variant NextMinigameData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("SkipSummaryScreen")] 
		public gamebbScriptID_Bool SkipSummaryScreen
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("PlayerPrograms")] 
		public gamebbScriptID_Variant PlayerPrograms
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(4)] 
		[RED("ActivePrograms")] 
		public gamebbScriptID_Variant ActivePrograms
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("ActiveTraps")] 
		public gamebbScriptID_Variant ActiveTraps
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(6)] 
		[RED("State")] 
		public gamebbScriptID_Int32 State
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(7)] 
		[RED("TimerLeftPercent")] 
		public gamebbScriptID_Float TimerLeftPercent
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(8)] 
		[RED("Entity")] 
		public gamebbScriptID_Variant Entity
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(9)] 
		[RED("IsJournalTarget")] 
		public gamebbScriptID_Bool IsJournalTarget
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public HackingMinigameDef()
		{
			MinigameDefaults = new gamebbScriptID_Variant();
			NextMinigameData = new gamebbScriptID_Variant();
			SkipSummaryScreen = new gamebbScriptID_Bool();
			PlayerPrograms = new gamebbScriptID_Variant();
			ActivePrograms = new gamebbScriptID_Variant();
			ActiveTraps = new gamebbScriptID_Variant();
			State = new gamebbScriptID_Int32();
			TimerLeftPercent = new gamebbScriptID_Float();
			Entity = new gamebbScriptID_Variant();
			IsJournalTarget = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
