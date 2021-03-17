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
			get => GetProperty(ref _timeLimit);
			set => SetProperty(ref _timeLimit, value);
		}

		[Ordinal(1)] 
		[RED("trapSpawnProbability")] 
		public CFloat TrapSpawnProbability
		{
			get => GetProperty(ref _trapSpawnProbability);
			set => SetProperty(ref _trapSpawnProbability, value);
		}

		[Ordinal(2)] 
		[RED("gridSize")] 
		public CUInt32 GridSize
		{
			get => GetProperty(ref _gridSize);
			set => SetProperty(ref _gridSize, value);
		}

		[Ordinal(3)] 
		[RED("bufferSize")] 
		public CUInt32 BufferSize
		{
			get => GetProperty(ref _bufferSize);
			set => SetProperty(ref _bufferSize, value);
		}

		[Ordinal(4)] 
		[RED("timerWaitsForInteraction")] 
		public CBool TimerWaitsForInteraction
		{
			get => GetProperty(ref _timerWaitsForInteraction);
			set => SetProperty(ref _timerWaitsForInteraction, value);
		}

		[Ordinal(5)] 
		[RED("acceptableTraps")] 
		public CArray<CHandle<gamedataMiniGame_Trap_Record>> AcceptableTraps
		{
			get => GetProperty(ref _acceptableTraps);
			set => SetProperty(ref _acceptableTraps, value);
		}

		[Ordinal(6)] 
		[RED("symbolsToUse")] 
		public CHandle<gamedataMiniGame_AllSymbols_Record> SymbolsToUse
		{
			get => GetProperty(ref _symbolsToUse);
			set => SetProperty(ref _symbolsToUse, value);
		}

		[Ordinal(7)] 
		[RED("rules")] 
		public CArray<CHandle<gameuiMinigameGenerationRule>> Rules
		{
			get => GetProperty(ref _rules);
			set => SetProperty(ref _rules, value);
		}

		public gameuiMinigameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
