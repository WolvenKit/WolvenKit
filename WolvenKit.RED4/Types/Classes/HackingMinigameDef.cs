using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackingMinigameDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("DeviceID")] 
		public gamebbScriptID_EntityID DeviceID
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(1)] 
		[RED("MinigameDefaults")] 
		public gamebbScriptID_Variant MinigameDefaults
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("NextMinigameData")] 
		public gamebbScriptID_Variant NextMinigameData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("SkipSummaryScreen")] 
		public gamebbScriptID_Bool SkipSummaryScreen
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("PlayerPrograms")] 
		public gamebbScriptID_Variant PlayerPrograms
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("ActivePrograms")] 
		public gamebbScriptID_Variant ActivePrograms
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(6)] 
		[RED("ActiveTraps")] 
		public gamebbScriptID_Variant ActiveTraps
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(7)] 
		[RED("State")] 
		public gamebbScriptID_Int32 State
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(8)] 
		[RED("TimerLeftPercent")] 
		public gamebbScriptID_Float TimerLeftPercent
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(9)] 
		[RED("Entity")] 
		public gamebbScriptID_Variant Entity
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(10)] 
		[RED("IsJournalTarget")] 
		public gamebbScriptID_Bool IsJournalTarget
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(11)] 
		[RED("LastPlayerHackPosition")] 
		public gamebbScriptID_Vector4 LastPlayerHackPosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		public HackingMinigameDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
