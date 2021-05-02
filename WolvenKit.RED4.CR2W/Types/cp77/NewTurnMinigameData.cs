using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewTurnMinigameData : CVariable
	{
		private Vector2 _position;
		private CBool _doConsume;
		private CEnum<HighlightMode> _nextHighlightMode;
		private CArray<ElementData> _newPlayerBufferContent;
		private CArray<ElementData> _newEnemyBufferContent;
		private CBool _doRegenerateGrid;
		private CArray<CellData> _regeneratedGridData;
		private ProgramProgressData _basicAccessCompletionState;
		private CArray<ProgramProgressData> _playerProgramsCompletionState;
		private CArray<ProgramProgressData> _enemyProgramsCompletionState;
		private CBool _playerProgramsChange;
		private CArray<ProgramData> _playerProgramsAdded;
		private CArray<ProgramData> _playerProgramsRemoved;
		private CBool _enemyProgramsChange;
		private CArray<ProgramData> _enemyprogramsAdded;
		private CArray<ProgramData> _enemyprogramsRemoved;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("doConsume")] 
		public CBool DoConsume
		{
			get => GetProperty(ref _doConsume);
			set => SetProperty(ref _doConsume, value);
		}

		[Ordinal(2)] 
		[RED("nextHighlightMode")] 
		public CEnum<HighlightMode> NextHighlightMode
		{
			get => GetProperty(ref _nextHighlightMode);
			set => SetProperty(ref _nextHighlightMode, value);
		}

		[Ordinal(3)] 
		[RED("newPlayerBufferContent")] 
		public CArray<ElementData> NewPlayerBufferContent
		{
			get => GetProperty(ref _newPlayerBufferContent);
			set => SetProperty(ref _newPlayerBufferContent, value);
		}

		[Ordinal(4)] 
		[RED("newEnemyBufferContent")] 
		public CArray<ElementData> NewEnemyBufferContent
		{
			get => GetProperty(ref _newEnemyBufferContent);
			set => SetProperty(ref _newEnemyBufferContent, value);
		}

		[Ordinal(5)] 
		[RED("doRegenerateGrid")] 
		public CBool DoRegenerateGrid
		{
			get => GetProperty(ref _doRegenerateGrid);
			set => SetProperty(ref _doRegenerateGrid, value);
		}

		[Ordinal(6)] 
		[RED("regeneratedGridData")] 
		public CArray<CellData> RegeneratedGridData
		{
			get => GetProperty(ref _regeneratedGridData);
			set => SetProperty(ref _regeneratedGridData, value);
		}

		[Ordinal(7)] 
		[RED("basicAccessCompletionState")] 
		public ProgramProgressData BasicAccessCompletionState
		{
			get => GetProperty(ref _basicAccessCompletionState);
			set => SetProperty(ref _basicAccessCompletionState, value);
		}

		[Ordinal(8)] 
		[RED("playerProgramsCompletionState")] 
		public CArray<ProgramProgressData> PlayerProgramsCompletionState
		{
			get => GetProperty(ref _playerProgramsCompletionState);
			set => SetProperty(ref _playerProgramsCompletionState, value);
		}

		[Ordinal(9)] 
		[RED("enemyProgramsCompletionState")] 
		public CArray<ProgramProgressData> EnemyProgramsCompletionState
		{
			get => GetProperty(ref _enemyProgramsCompletionState);
			set => SetProperty(ref _enemyProgramsCompletionState, value);
		}

		[Ordinal(10)] 
		[RED("playerProgramsChange")] 
		public CBool PlayerProgramsChange
		{
			get => GetProperty(ref _playerProgramsChange);
			set => SetProperty(ref _playerProgramsChange, value);
		}

		[Ordinal(11)] 
		[RED("playerProgramsAdded")] 
		public CArray<ProgramData> PlayerProgramsAdded
		{
			get => GetProperty(ref _playerProgramsAdded);
			set => SetProperty(ref _playerProgramsAdded, value);
		}

		[Ordinal(12)] 
		[RED("playerProgramsRemoved")] 
		public CArray<ProgramData> PlayerProgramsRemoved
		{
			get => GetProperty(ref _playerProgramsRemoved);
			set => SetProperty(ref _playerProgramsRemoved, value);
		}

		[Ordinal(13)] 
		[RED("enemyProgramsChange")] 
		public CBool EnemyProgramsChange
		{
			get => GetProperty(ref _enemyProgramsChange);
			set => SetProperty(ref _enemyProgramsChange, value);
		}

		[Ordinal(14)] 
		[RED("enemyprogramsAdded")] 
		public CArray<ProgramData> EnemyprogramsAdded
		{
			get => GetProperty(ref _enemyprogramsAdded);
			set => SetProperty(ref _enemyprogramsAdded, value);
		}

		[Ordinal(15)] 
		[RED("enemyprogramsRemoved")] 
		public CArray<ProgramData> EnemyprogramsRemoved
		{
			get => GetProperty(ref _enemyprogramsRemoved);
			set => SetProperty(ref _enemyprogramsRemoved, value);
		}

		public NewTurnMinigameData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
