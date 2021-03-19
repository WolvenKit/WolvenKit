using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkInkGameController : gameuiWidgetGameController
	{
		private CString _turn;
		private CInt32 _dimension;
		private CInt32 _steps;
		private CArray<CString> _symbols;
		private CArray<CInt32> _symbolProbabilities;
		private CBool _endGame;
		private CBool _initRound;
		private CInt32 _oldPickX;
		private CInt32 _oldPickY;
		private CInt32 _pickX;
		private CInt32 _pickY;
		private CBool _regenGrid;
		private CArray<CString> _trapsDelayed;
		private NetworkMinigameData _networkData;
		private wCHandle<NetworkMinigameVisualController> _visualController;
		private wCHandle<gamedataHackingMiniGame_Record> _miniGameRecord;
		private CBool _officerBreach;
		private CArray<ElementData> _bufferElements;
		private CArray<ElementData> _enemyBufferElements;
		private CArray<CString> _completedPrograms;
		private CArray<ProgramData> _completedProgramsPD;
		private CArray<CString> _enemyCompletedPrograms;
		private CArray<ProgramData> _enemyCompletedProgramsPD;
		private CArray<ProgramProgressData> _playerProgramsCompletion;
		private CArray<ProgramProgressData> _enemyProgramsCompletion;
		private ProgramProgressData _basicAccessCompletion;
		private CArray<CEnum<ExtraEffect>> _appliedViruses;
		private CUInt32 _onBreachingNetworkListener;
		private CUInt32 _onDevicesCountChangedListener;

		[Ordinal(2)] 
		[RED("turn")] 
		public CString Turn
		{
			get => GetProperty(ref _turn);
			set => SetProperty(ref _turn, value);
		}

		[Ordinal(3)] 
		[RED("dimension")] 
		public CInt32 Dimension
		{
			get => GetProperty(ref _dimension);
			set => SetProperty(ref _dimension, value);
		}

		[Ordinal(4)] 
		[RED("steps")] 
		public CInt32 Steps
		{
			get => GetProperty(ref _steps);
			set => SetProperty(ref _steps, value);
		}

		[Ordinal(5)] 
		[RED("symbols")] 
		public CArray<CString> Symbols
		{
			get => GetProperty(ref _symbols);
			set => SetProperty(ref _symbols, value);
		}

		[Ordinal(6)] 
		[RED("symbolProbabilities")] 
		public CArray<CInt32> SymbolProbabilities
		{
			get => GetProperty(ref _symbolProbabilities);
			set => SetProperty(ref _symbolProbabilities, value);
		}

		[Ordinal(7)] 
		[RED("endGame")] 
		public CBool EndGame
		{
			get => GetProperty(ref _endGame);
			set => SetProperty(ref _endGame, value);
		}

		[Ordinal(8)] 
		[RED("initRound")] 
		public CBool InitRound
		{
			get => GetProperty(ref _initRound);
			set => SetProperty(ref _initRound, value);
		}

		[Ordinal(9)] 
		[RED("oldPickX")] 
		public CInt32 OldPickX
		{
			get => GetProperty(ref _oldPickX);
			set => SetProperty(ref _oldPickX, value);
		}

		[Ordinal(10)] 
		[RED("oldPickY")] 
		public CInt32 OldPickY
		{
			get => GetProperty(ref _oldPickY);
			set => SetProperty(ref _oldPickY, value);
		}

		[Ordinal(11)] 
		[RED("pickX")] 
		public CInt32 PickX
		{
			get => GetProperty(ref _pickX);
			set => SetProperty(ref _pickX, value);
		}

		[Ordinal(12)] 
		[RED("pickY")] 
		public CInt32 PickY
		{
			get => GetProperty(ref _pickY);
			set => SetProperty(ref _pickY, value);
		}

		[Ordinal(13)] 
		[RED("regenGrid")] 
		public CBool RegenGrid
		{
			get => GetProperty(ref _regenGrid);
			set => SetProperty(ref _regenGrid, value);
		}

		[Ordinal(14)] 
		[RED("trapsDelayed")] 
		public CArray<CString> TrapsDelayed
		{
			get => GetProperty(ref _trapsDelayed);
			set => SetProperty(ref _trapsDelayed, value);
		}

		[Ordinal(15)] 
		[RED("networkData")] 
		public NetworkMinigameData NetworkData
		{
			get => GetProperty(ref _networkData);
			set => SetProperty(ref _networkData, value);
		}

		[Ordinal(16)] 
		[RED("visualController")] 
		public wCHandle<NetworkMinigameVisualController> VisualController
		{
			get => GetProperty(ref _visualController);
			set => SetProperty(ref _visualController, value);
		}

		[Ordinal(17)] 
		[RED("miniGameRecord")] 
		public wCHandle<gamedataHackingMiniGame_Record> MiniGameRecord
		{
			get => GetProperty(ref _miniGameRecord);
			set => SetProperty(ref _miniGameRecord, value);
		}

		[Ordinal(18)] 
		[RED("officerBreach")] 
		public CBool OfficerBreach
		{
			get => GetProperty(ref _officerBreach);
			set => SetProperty(ref _officerBreach, value);
		}

		[Ordinal(19)] 
		[RED("bufferElements")] 
		public CArray<ElementData> BufferElements
		{
			get => GetProperty(ref _bufferElements);
			set => SetProperty(ref _bufferElements, value);
		}

		[Ordinal(20)] 
		[RED("enemyBufferElements")] 
		public CArray<ElementData> EnemyBufferElements
		{
			get => GetProperty(ref _enemyBufferElements);
			set => SetProperty(ref _enemyBufferElements, value);
		}

		[Ordinal(21)] 
		[RED("completedPrograms")] 
		public CArray<CString> CompletedPrograms
		{
			get => GetProperty(ref _completedPrograms);
			set => SetProperty(ref _completedPrograms, value);
		}

		[Ordinal(22)] 
		[RED("completedProgramsPD")] 
		public CArray<ProgramData> CompletedProgramsPD
		{
			get => GetProperty(ref _completedProgramsPD);
			set => SetProperty(ref _completedProgramsPD, value);
		}

		[Ordinal(23)] 
		[RED("enemyCompletedPrograms")] 
		public CArray<CString> EnemyCompletedPrograms
		{
			get => GetProperty(ref _enemyCompletedPrograms);
			set => SetProperty(ref _enemyCompletedPrograms, value);
		}

		[Ordinal(24)] 
		[RED("enemyCompletedProgramsPD")] 
		public CArray<ProgramData> EnemyCompletedProgramsPD
		{
			get => GetProperty(ref _enemyCompletedProgramsPD);
			set => SetProperty(ref _enemyCompletedProgramsPD, value);
		}

		[Ordinal(25)] 
		[RED("playerProgramsCompletion")] 
		public CArray<ProgramProgressData> PlayerProgramsCompletion
		{
			get => GetProperty(ref _playerProgramsCompletion);
			set => SetProperty(ref _playerProgramsCompletion, value);
		}

		[Ordinal(26)] 
		[RED("enemyProgramsCompletion")] 
		public CArray<ProgramProgressData> EnemyProgramsCompletion
		{
			get => GetProperty(ref _enemyProgramsCompletion);
			set => SetProperty(ref _enemyProgramsCompletion, value);
		}

		[Ordinal(27)] 
		[RED("basicAccessCompletion")] 
		public ProgramProgressData BasicAccessCompletion
		{
			get => GetProperty(ref _basicAccessCompletion);
			set => SetProperty(ref _basicAccessCompletion, value);
		}

		[Ordinal(28)] 
		[RED("appliedViruses")] 
		public CArray<CEnum<ExtraEffect>> AppliedViruses
		{
			get => GetProperty(ref _appliedViruses);
			set => SetProperty(ref _appliedViruses, value);
		}

		[Ordinal(29)] 
		[RED("onBreachingNetworkListener")] 
		public CUInt32 OnBreachingNetworkListener
		{
			get => GetProperty(ref _onBreachingNetworkListener);
			set => SetProperty(ref _onBreachingNetworkListener, value);
		}

		[Ordinal(30)] 
		[RED("onDevicesCountChangedListener")] 
		public CUInt32 OnDevicesCountChangedListener
		{
			get => GetProperty(ref _onDevicesCountChangedListener);
			set => SetProperty(ref _onDevicesCountChangedListener, value);
		}

		public NetworkInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
