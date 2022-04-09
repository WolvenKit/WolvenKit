using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkInkGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("turn")] 
		public CString Turn
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("dimension")] 
		public CInt32 Dimension
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("steps")] 
		public CInt32 Steps
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("symbols")] 
		public CArray<CString> Symbols
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(6)] 
		[RED("symbolProbabilities")] 
		public CArray<CInt32> SymbolProbabilities
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(7)] 
		[RED("endGame")] 
		public CBool EndGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("initRound")] 
		public CBool InitRound
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("oldPickX")] 
		public CInt32 OldPickX
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("oldPickY")] 
		public CInt32 OldPickY
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("pickX")] 
		public CInt32 PickX
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("pickY")] 
		public CInt32 PickY
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("regenGrid")] 
		public CBool RegenGrid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("trapsDelayed")] 
		public CArray<CString> TrapsDelayed
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(15)] 
		[RED("networkData")] 
		public NetworkMinigameData NetworkData
		{
			get => GetPropertyValue<NetworkMinigameData>();
			set => SetPropertyValue<NetworkMinigameData>(value);
		}

		[Ordinal(16)] 
		[RED("visualController")] 
		public CWeakHandle<NetworkMinigameVisualController> VisualController
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameVisualController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameVisualController>>(value);
		}

		[Ordinal(17)] 
		[RED("miniGameRecord")] 
		public CWeakHandle<gamedataHackingMiniGame_Record> MiniGameRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataHackingMiniGame_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataHackingMiniGame_Record>>(value);
		}

		[Ordinal(18)] 
		[RED("officerBreach")] 
		public CBool OfficerBreach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("bufferElements")] 
		public CArray<ElementData> BufferElements
		{
			get => GetPropertyValue<CArray<ElementData>>();
			set => SetPropertyValue<CArray<ElementData>>(value);
		}

		[Ordinal(20)] 
		[RED("enemyBufferElements")] 
		public CArray<ElementData> EnemyBufferElements
		{
			get => GetPropertyValue<CArray<ElementData>>();
			set => SetPropertyValue<CArray<ElementData>>(value);
		}

		[Ordinal(21)] 
		[RED("completedPrograms")] 
		public CArray<CString> CompletedPrograms
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(22)] 
		[RED("completedProgramsPD")] 
		public CArray<ProgramData> CompletedProgramsPD
		{
			get => GetPropertyValue<CArray<ProgramData>>();
			set => SetPropertyValue<CArray<ProgramData>>(value);
		}

		[Ordinal(23)] 
		[RED("enemyCompletedPrograms")] 
		public CArray<CString> EnemyCompletedPrograms
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(24)] 
		[RED("enemyCompletedProgramsPD")] 
		public CArray<ProgramData> EnemyCompletedProgramsPD
		{
			get => GetPropertyValue<CArray<ProgramData>>();
			set => SetPropertyValue<CArray<ProgramData>>(value);
		}

		[Ordinal(25)] 
		[RED("playerProgramsCompletion")] 
		public CArray<ProgramProgressData> PlayerProgramsCompletion
		{
			get => GetPropertyValue<CArray<ProgramProgressData>>();
			set => SetPropertyValue<CArray<ProgramProgressData>>(value);
		}

		[Ordinal(26)] 
		[RED("enemyProgramsCompletion")] 
		public CArray<ProgramProgressData> EnemyProgramsCompletion
		{
			get => GetPropertyValue<CArray<ProgramProgressData>>();
			set => SetPropertyValue<CArray<ProgramProgressData>>(value);
		}

		[Ordinal(27)] 
		[RED("basicAccessCompletion")] 
		public ProgramProgressData BasicAccessCompletion
		{
			get => GetPropertyValue<ProgramProgressData>();
			set => SetPropertyValue<ProgramProgressData>(value);
		}

		[Ordinal(28)] 
		[RED("appliedViruses")] 
		public CArray<CEnum<ExtraEffect>> AppliedViruses
		{
			get => GetPropertyValue<CArray<CEnum<ExtraEffect>>>();
			set => SetPropertyValue<CArray<CEnum<ExtraEffect>>>(value);
		}

		[Ordinal(29)] 
		[RED("onBreachingNetworkListener")] 
		public CHandle<redCallbackObject> OnBreachingNetworkListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("onDevicesCountChangedListener")] 
		public CHandle<redCallbackObject> OnDevicesCountChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public NetworkInkGameController()
		{
			Turn = "Initial";
			Dimension = 5;
			Steps = 6;
			Symbols = new();
			SymbolProbabilities = new();
			InitRound = true;
			TrapsDelayed = new();
			NetworkData = new() { GridData = new(), BasicAccess = new() { CommandLists = new(), Effects = new() }, PlayerPrograms = new(), EnemyLockNetwork = new() { CommandLists = new(), Effects = new() }, EnemyPrograms = new() };
			BufferElements = new();
			EnemyBufferElements = new();
			CompletedPrograms = new();
			CompletedProgramsPD = new();
			EnemyCompletedPrograms = new();
			EnemyCompletedProgramsPD = new();
			PlayerProgramsCompletion = new();
			EnemyProgramsCompletion = new();
			BasicAccessCompletion = new() { CompletionProgress = new() };
			AppliedViruses = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
