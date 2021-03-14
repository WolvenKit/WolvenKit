using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameData : CVariable
	{
		private CFloat _timeLimit;
		private CFloat _trapSpawnProbability;
		private CUInt32 _gridSize;
		private CUInt32 _bufferSize;
		private CBool _timerWaitsForInteraction;
		private CArray<CHandle<gamedataMiniGame_Trap_Record>> _acceptableTraps;
		private CHandle<gamedataMiniGame_AllSymbols_Record> _symbolsToUse;
		private CArray<CHandle<gameuiMinigameGenerationRule>> _rules;

		[Ordinal(0)] 
		[RED("timeLimit")] 
		public CFloat TimeLimit
		{
			get
			{
				if (_timeLimit == null)
				{
					_timeLimit = (CFloat) CR2WTypeManager.Create("Float", "timeLimit", cr2w, this);
				}
				return _timeLimit;
			}
			set
			{
				if (_timeLimit == value)
				{
					return;
				}
				_timeLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("trapSpawnProbability")] 
		public CFloat TrapSpawnProbability
		{
			get
			{
				if (_trapSpawnProbability == null)
				{
					_trapSpawnProbability = (CFloat) CR2WTypeManager.Create("Float", "trapSpawnProbability", cr2w, this);
				}
				return _trapSpawnProbability;
			}
			set
			{
				if (_trapSpawnProbability == value)
				{
					return;
				}
				_trapSpawnProbability = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("gridSize")] 
		public CUInt32 GridSize
		{
			get
			{
				if (_gridSize == null)
				{
					_gridSize = (CUInt32) CR2WTypeManager.Create("Uint32", "gridSize", cr2w, this);
				}
				return _gridSize;
			}
			set
			{
				if (_gridSize == value)
				{
					return;
				}
				_gridSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bufferSize")] 
		public CUInt32 BufferSize
		{
			get
			{
				if (_bufferSize == null)
				{
					_bufferSize = (CUInt32) CR2WTypeManager.Create("Uint32", "bufferSize", cr2w, this);
				}
				return _bufferSize;
			}
			set
			{
				if (_bufferSize == value)
				{
					return;
				}
				_bufferSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("timerWaitsForInteraction")] 
		public CBool TimerWaitsForInteraction
		{
			get
			{
				if (_timerWaitsForInteraction == null)
				{
					_timerWaitsForInteraction = (CBool) CR2WTypeManager.Create("Bool", "timerWaitsForInteraction", cr2w, this);
				}
				return _timerWaitsForInteraction;
			}
			set
			{
				if (_timerWaitsForInteraction == value)
				{
					return;
				}
				_timerWaitsForInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("acceptableTraps")] 
		public CArray<CHandle<gamedataMiniGame_Trap_Record>> AcceptableTraps
		{
			get
			{
				if (_acceptableTraps == null)
				{
					_acceptableTraps = (CArray<CHandle<gamedataMiniGame_Trap_Record>>) CR2WTypeManager.Create("array:handle:gamedataMiniGame_Trap_Record", "acceptableTraps", cr2w, this);
				}
				return _acceptableTraps;
			}
			set
			{
				if (_acceptableTraps == value)
				{
					return;
				}
				_acceptableTraps = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("symbolsToUse")] 
		public CHandle<gamedataMiniGame_AllSymbols_Record> SymbolsToUse
		{
			get
			{
				if (_symbolsToUse == null)
				{
					_symbolsToUse = (CHandle<gamedataMiniGame_AllSymbols_Record>) CR2WTypeManager.Create("handle:gamedataMiniGame_AllSymbols_Record", "symbolsToUse", cr2w, this);
				}
				return _symbolsToUse;
			}
			set
			{
				if (_symbolsToUse == value)
				{
					return;
				}
				_symbolsToUse = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("rules")] 
		public CArray<CHandle<gameuiMinigameGenerationRule>> Rules
		{
			get
			{
				if (_rules == null)
				{
					_rules = (CArray<CHandle<gameuiMinigameGenerationRule>>) CR2WTypeManager.Create("array:handle:gameuiMinigameGenerationRule", "rules", cr2w, this);
				}
				return _rules;
			}
			set
			{
				if (_rules == value)
				{
					return;
				}
				_rules = value;
				PropertySet(this);
			}
		}

		public gameuiMinigameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
