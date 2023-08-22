using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewTurnMinigameData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("doConsume")] 
		public CBool DoConsume
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("nextHighlightMode")] 
		public CEnum<HighlightMode> NextHighlightMode
		{
			get => GetPropertyValue<CEnum<HighlightMode>>();
			set => SetPropertyValue<CEnum<HighlightMode>>(value);
		}

		[Ordinal(3)] 
		[RED("newPlayerBufferContent")] 
		public CArray<ElementData> NewPlayerBufferContent
		{
			get => GetPropertyValue<CArray<ElementData>>();
			set => SetPropertyValue<CArray<ElementData>>(value);
		}

		[Ordinal(4)] 
		[RED("newEnemyBufferContent")] 
		public CArray<ElementData> NewEnemyBufferContent
		{
			get => GetPropertyValue<CArray<ElementData>>();
			set => SetPropertyValue<CArray<ElementData>>(value);
		}

		[Ordinal(5)] 
		[RED("doRegenerateGrid")] 
		public CBool DoRegenerateGrid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("regeneratedGridData")] 
		public CArray<CellData> RegeneratedGridData
		{
			get => GetPropertyValue<CArray<CellData>>();
			set => SetPropertyValue<CArray<CellData>>(value);
		}

		[Ordinal(7)] 
		[RED("basicAccessCompletionState")] 
		public ProgramProgressData BasicAccessCompletionState
		{
			get => GetPropertyValue<ProgramProgressData>();
			set => SetPropertyValue<ProgramProgressData>(value);
		}

		[Ordinal(8)] 
		[RED("playerProgramsCompletionState")] 
		public CArray<ProgramProgressData> PlayerProgramsCompletionState
		{
			get => GetPropertyValue<CArray<ProgramProgressData>>();
			set => SetPropertyValue<CArray<ProgramProgressData>>(value);
		}

		[Ordinal(9)] 
		[RED("enemyProgramsCompletionState")] 
		public CArray<ProgramProgressData> EnemyProgramsCompletionState
		{
			get => GetPropertyValue<CArray<ProgramProgressData>>();
			set => SetPropertyValue<CArray<ProgramProgressData>>(value);
		}

		[Ordinal(10)] 
		[RED("playerProgramsChange")] 
		public CBool PlayerProgramsChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("playerProgramsAdded")] 
		public CArray<ProgramData> PlayerProgramsAdded
		{
			get => GetPropertyValue<CArray<ProgramData>>();
			set => SetPropertyValue<CArray<ProgramData>>(value);
		}

		[Ordinal(12)] 
		[RED("playerProgramsRemoved")] 
		public CArray<ProgramData> PlayerProgramsRemoved
		{
			get => GetPropertyValue<CArray<ProgramData>>();
			set => SetPropertyValue<CArray<ProgramData>>(value);
		}

		[Ordinal(13)] 
		[RED("enemyProgramsChange")] 
		public CBool EnemyProgramsChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("enemyprogramsAdded")] 
		public CArray<ProgramData> EnemyprogramsAdded
		{
			get => GetPropertyValue<CArray<ProgramData>>();
			set => SetPropertyValue<CArray<ProgramData>>(value);
		}

		[Ordinal(15)] 
		[RED("enemyprogramsRemoved")] 
		public CArray<ProgramData> EnemyprogramsRemoved
		{
			get => GetPropertyValue<CArray<ProgramData>>();
			set => SetPropertyValue<CArray<ProgramData>>(value);
		}

		public NewTurnMinigameData()
		{
			Position = new Vector2();
			NewPlayerBufferContent = new();
			NewEnemyBufferContent = new();
			RegeneratedGridData = new();
			BasicAccessCompletionState = new ProgramProgressData { CompletionProgress = new() };
			PlayerProgramsCompletionState = new();
			EnemyProgramsCompletionState = new();
			PlayerProgramsAdded = new();
			PlayerProgramsRemoved = new();
			EnemyprogramsAdded = new();
			EnemyprogramsRemoved = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
