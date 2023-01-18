using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinigameData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("timeLimit")] 
		public CFloat TimeLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("trapSpawnProbability")] 
		public CFloat TrapSpawnProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("gridSize")] 
		public CUInt32 GridSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("bufferSize")] 
		public CUInt32 BufferSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("timerWaitsForInteraction")] 
		public CBool TimerWaitsForInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("acceptableTraps")] 
		public CArray<CHandle<gamedataMiniGame_Trap_Record>> AcceptableTraps
		{
			get => GetPropertyValue<CArray<CHandle<gamedataMiniGame_Trap_Record>>>();
			set => SetPropertyValue<CArray<CHandle<gamedataMiniGame_Trap_Record>>>(value);
		}

		[Ordinal(6)] 
		[RED("symbolsToUse")] 
		public CHandle<gamedataMiniGame_AllSymbols_Record> SymbolsToUse
		{
			get => GetPropertyValue<CHandle<gamedataMiniGame_AllSymbols_Record>>();
			set => SetPropertyValue<CHandle<gamedataMiniGame_AllSymbols_Record>>(value);
		}

		[Ordinal(7)] 
		[RED("rules")] 
		public CArray<CHandle<gameuiMinigameGenerationRule>> Rules
		{
			get => GetPropertyValue<CArray<CHandle<gameuiMinigameGenerationRule>>>();
			set => SetPropertyValue<CArray<CHandle<gameuiMinigameGenerationRule>>>(value);
		}

		public gameuiMinigameData()
		{
			TimeLimit = 100.000000F;
			TrapSpawnProbability = -1.000000F;
			GridSize = 6;
			BufferSize = 7;
			TimerWaitsForInteraction = true;
			AcceptableTraps = new();
			Rules = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
