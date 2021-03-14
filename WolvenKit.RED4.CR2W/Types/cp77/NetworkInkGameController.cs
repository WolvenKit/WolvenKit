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
			get
			{
				if (_turn == null)
				{
					_turn = (CString) CR2WTypeManager.Create("String", "turn", cr2w, this);
				}
				return _turn;
			}
			set
			{
				if (_turn == value)
				{
					return;
				}
				_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dimension")] 
		public CInt32 Dimension
		{
			get
			{
				if (_dimension == null)
				{
					_dimension = (CInt32) CR2WTypeManager.Create("Int32", "dimension", cr2w, this);
				}
				return _dimension;
			}
			set
			{
				if (_dimension == value)
				{
					return;
				}
				_dimension = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("steps")] 
		public CInt32 Steps
		{
			get
			{
				if (_steps == null)
				{
					_steps = (CInt32) CR2WTypeManager.Create("Int32", "steps", cr2w, this);
				}
				return _steps;
			}
			set
			{
				if (_steps == value)
				{
					return;
				}
				_steps = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("symbols")] 
		public CArray<CString> Symbols
		{
			get
			{
				if (_symbols == null)
				{
					_symbols = (CArray<CString>) CR2WTypeManager.Create("array:String", "symbols", cr2w, this);
				}
				return _symbols;
			}
			set
			{
				if (_symbols == value)
				{
					return;
				}
				_symbols = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("symbolProbabilities")] 
		public CArray<CInt32> SymbolProbabilities
		{
			get
			{
				if (_symbolProbabilities == null)
				{
					_symbolProbabilities = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "symbolProbabilities", cr2w, this);
				}
				return _symbolProbabilities;
			}
			set
			{
				if (_symbolProbabilities == value)
				{
					return;
				}
				_symbolProbabilities = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("endGame")] 
		public CBool EndGame
		{
			get
			{
				if (_endGame == null)
				{
					_endGame = (CBool) CR2WTypeManager.Create("Bool", "endGame", cr2w, this);
				}
				return _endGame;
			}
			set
			{
				if (_endGame == value)
				{
					return;
				}
				_endGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("initRound")] 
		public CBool InitRound
		{
			get
			{
				if (_initRound == null)
				{
					_initRound = (CBool) CR2WTypeManager.Create("Bool", "initRound", cr2w, this);
				}
				return _initRound;
			}
			set
			{
				if (_initRound == value)
				{
					return;
				}
				_initRound = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("oldPickX")] 
		public CInt32 OldPickX
		{
			get
			{
				if (_oldPickX == null)
				{
					_oldPickX = (CInt32) CR2WTypeManager.Create("Int32", "oldPickX", cr2w, this);
				}
				return _oldPickX;
			}
			set
			{
				if (_oldPickX == value)
				{
					return;
				}
				_oldPickX = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("oldPickY")] 
		public CInt32 OldPickY
		{
			get
			{
				if (_oldPickY == null)
				{
					_oldPickY = (CInt32) CR2WTypeManager.Create("Int32", "oldPickY", cr2w, this);
				}
				return _oldPickY;
			}
			set
			{
				if (_oldPickY == value)
				{
					return;
				}
				_oldPickY = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("pickX")] 
		public CInt32 PickX
		{
			get
			{
				if (_pickX == null)
				{
					_pickX = (CInt32) CR2WTypeManager.Create("Int32", "pickX", cr2w, this);
				}
				return _pickX;
			}
			set
			{
				if (_pickX == value)
				{
					return;
				}
				_pickX = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("pickY")] 
		public CInt32 PickY
		{
			get
			{
				if (_pickY == null)
				{
					_pickY = (CInt32) CR2WTypeManager.Create("Int32", "pickY", cr2w, this);
				}
				return _pickY;
			}
			set
			{
				if (_pickY == value)
				{
					return;
				}
				_pickY = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("regenGrid")] 
		public CBool RegenGrid
		{
			get
			{
				if (_regenGrid == null)
				{
					_regenGrid = (CBool) CR2WTypeManager.Create("Bool", "regenGrid", cr2w, this);
				}
				return _regenGrid;
			}
			set
			{
				if (_regenGrid == value)
				{
					return;
				}
				_regenGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("trapsDelayed")] 
		public CArray<CString> TrapsDelayed
		{
			get
			{
				if (_trapsDelayed == null)
				{
					_trapsDelayed = (CArray<CString>) CR2WTypeManager.Create("array:String", "trapsDelayed", cr2w, this);
				}
				return _trapsDelayed;
			}
			set
			{
				if (_trapsDelayed == value)
				{
					return;
				}
				_trapsDelayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("networkData")] 
		public NetworkMinigameData NetworkData
		{
			get
			{
				if (_networkData == null)
				{
					_networkData = (NetworkMinigameData) CR2WTypeManager.Create("NetworkMinigameData", "networkData", cr2w, this);
				}
				return _networkData;
			}
			set
			{
				if (_networkData == value)
				{
					return;
				}
				_networkData = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("visualController")] 
		public wCHandle<NetworkMinigameVisualController> VisualController
		{
			get
			{
				if (_visualController == null)
				{
					_visualController = (wCHandle<NetworkMinigameVisualController>) CR2WTypeManager.Create("whandle:NetworkMinigameVisualController", "visualController", cr2w, this);
				}
				return _visualController;
			}
			set
			{
				if (_visualController == value)
				{
					return;
				}
				_visualController = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("miniGameRecord")] 
		public wCHandle<gamedataHackingMiniGame_Record> MiniGameRecord
		{
			get
			{
				if (_miniGameRecord == null)
				{
					_miniGameRecord = (wCHandle<gamedataHackingMiniGame_Record>) CR2WTypeManager.Create("whandle:gamedataHackingMiniGame_Record", "miniGameRecord", cr2w, this);
				}
				return _miniGameRecord;
			}
			set
			{
				if (_miniGameRecord == value)
				{
					return;
				}
				_miniGameRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("officerBreach")] 
		public CBool OfficerBreach
		{
			get
			{
				if (_officerBreach == null)
				{
					_officerBreach = (CBool) CR2WTypeManager.Create("Bool", "officerBreach", cr2w, this);
				}
				return _officerBreach;
			}
			set
			{
				if (_officerBreach == value)
				{
					return;
				}
				_officerBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("bufferElements")] 
		public CArray<ElementData> BufferElements
		{
			get
			{
				if (_bufferElements == null)
				{
					_bufferElements = (CArray<ElementData>) CR2WTypeManager.Create("array:ElementData", "bufferElements", cr2w, this);
				}
				return _bufferElements;
			}
			set
			{
				if (_bufferElements == value)
				{
					return;
				}
				_bufferElements = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("enemyBufferElements")] 
		public CArray<ElementData> EnemyBufferElements
		{
			get
			{
				if (_enemyBufferElements == null)
				{
					_enemyBufferElements = (CArray<ElementData>) CR2WTypeManager.Create("array:ElementData", "enemyBufferElements", cr2w, this);
				}
				return _enemyBufferElements;
			}
			set
			{
				if (_enemyBufferElements == value)
				{
					return;
				}
				_enemyBufferElements = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("completedPrograms")] 
		public CArray<CString> CompletedPrograms
		{
			get
			{
				if (_completedPrograms == null)
				{
					_completedPrograms = (CArray<CString>) CR2WTypeManager.Create("array:String", "completedPrograms", cr2w, this);
				}
				return _completedPrograms;
			}
			set
			{
				if (_completedPrograms == value)
				{
					return;
				}
				_completedPrograms = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("completedProgramsPD")] 
		public CArray<ProgramData> CompletedProgramsPD
		{
			get
			{
				if (_completedProgramsPD == null)
				{
					_completedProgramsPD = (CArray<ProgramData>) CR2WTypeManager.Create("array:ProgramData", "completedProgramsPD", cr2w, this);
				}
				return _completedProgramsPD;
			}
			set
			{
				if (_completedProgramsPD == value)
				{
					return;
				}
				_completedProgramsPD = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("enemyCompletedPrograms")] 
		public CArray<CString> EnemyCompletedPrograms
		{
			get
			{
				if (_enemyCompletedPrograms == null)
				{
					_enemyCompletedPrograms = (CArray<CString>) CR2WTypeManager.Create("array:String", "enemyCompletedPrograms", cr2w, this);
				}
				return _enemyCompletedPrograms;
			}
			set
			{
				if (_enemyCompletedPrograms == value)
				{
					return;
				}
				_enemyCompletedPrograms = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("enemyCompletedProgramsPD")] 
		public CArray<ProgramData> EnemyCompletedProgramsPD
		{
			get
			{
				if (_enemyCompletedProgramsPD == null)
				{
					_enemyCompletedProgramsPD = (CArray<ProgramData>) CR2WTypeManager.Create("array:ProgramData", "enemyCompletedProgramsPD", cr2w, this);
				}
				return _enemyCompletedProgramsPD;
			}
			set
			{
				if (_enemyCompletedProgramsPD == value)
				{
					return;
				}
				_enemyCompletedProgramsPD = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("playerProgramsCompletion")] 
		public CArray<ProgramProgressData> PlayerProgramsCompletion
		{
			get
			{
				if (_playerProgramsCompletion == null)
				{
					_playerProgramsCompletion = (CArray<ProgramProgressData>) CR2WTypeManager.Create("array:ProgramProgressData", "playerProgramsCompletion", cr2w, this);
				}
				return _playerProgramsCompletion;
			}
			set
			{
				if (_playerProgramsCompletion == value)
				{
					return;
				}
				_playerProgramsCompletion = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("enemyProgramsCompletion")] 
		public CArray<ProgramProgressData> EnemyProgramsCompletion
		{
			get
			{
				if (_enemyProgramsCompletion == null)
				{
					_enemyProgramsCompletion = (CArray<ProgramProgressData>) CR2WTypeManager.Create("array:ProgramProgressData", "enemyProgramsCompletion", cr2w, this);
				}
				return _enemyProgramsCompletion;
			}
			set
			{
				if (_enemyProgramsCompletion == value)
				{
					return;
				}
				_enemyProgramsCompletion = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("basicAccessCompletion")] 
		public ProgramProgressData BasicAccessCompletion
		{
			get
			{
				if (_basicAccessCompletion == null)
				{
					_basicAccessCompletion = (ProgramProgressData) CR2WTypeManager.Create("ProgramProgressData", "basicAccessCompletion", cr2w, this);
				}
				return _basicAccessCompletion;
			}
			set
			{
				if (_basicAccessCompletion == value)
				{
					return;
				}
				_basicAccessCompletion = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("appliedViruses")] 
		public CArray<CEnum<ExtraEffect>> AppliedViruses
		{
			get
			{
				if (_appliedViruses == null)
				{
					_appliedViruses = (CArray<CEnum<ExtraEffect>>) CR2WTypeManager.Create("array:ExtraEffect", "appliedViruses", cr2w, this);
				}
				return _appliedViruses;
			}
			set
			{
				if (_appliedViruses == value)
				{
					return;
				}
				_appliedViruses = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("onBreachingNetworkListener")] 
		public CUInt32 OnBreachingNetworkListener
		{
			get
			{
				if (_onBreachingNetworkListener == null)
				{
					_onBreachingNetworkListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onBreachingNetworkListener", cr2w, this);
				}
				return _onBreachingNetworkListener;
			}
			set
			{
				if (_onBreachingNetworkListener == value)
				{
					return;
				}
				_onBreachingNetworkListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("onDevicesCountChangedListener")] 
		public CUInt32 OnDevicesCountChangedListener
		{
			get
			{
				if (_onDevicesCountChangedListener == null)
				{
					_onDevicesCountChangedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onDevicesCountChangedListener", cr2w, this);
				}
				return _onDevicesCountChangedListener;
			}
			set
			{
				if (_onDevicesCountChangedListener == value)
				{
					return;
				}
				_onDevicesCountChangedListener = value;
				PropertySet(this);
			}
		}

		public NetworkInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
