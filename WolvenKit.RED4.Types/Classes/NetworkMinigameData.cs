using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkMinigameData : RedBaseClass
	{
		private CArray<CellData> _gridData;
		private CInt32 _playerBufferSize;
		private ProgramData _basicAccess;
		private CArray<ProgramData> _playerPrograms;
		private CInt32 _enemyBufferSize;
		private ProgramData _enemyLockNetwork;
		private CArray<ProgramData> _enemyPrograms;

		[Ordinal(0)] 
		[RED("gridData")] 
		public CArray<CellData> GridData
		{
			get => GetProperty(ref _gridData);
			set => SetProperty(ref _gridData, value);
		}

		[Ordinal(1)] 
		[RED("playerBufferSize")] 
		public CInt32 PlayerBufferSize
		{
			get => GetProperty(ref _playerBufferSize);
			set => SetProperty(ref _playerBufferSize, value);
		}

		[Ordinal(2)] 
		[RED("basicAccess")] 
		public ProgramData BasicAccess
		{
			get => GetProperty(ref _basicAccess);
			set => SetProperty(ref _basicAccess, value);
		}

		[Ordinal(3)] 
		[RED("playerPrograms")] 
		public CArray<ProgramData> PlayerPrograms
		{
			get => GetProperty(ref _playerPrograms);
			set => SetProperty(ref _playerPrograms, value);
		}

		[Ordinal(4)] 
		[RED("enemyBufferSize")] 
		public CInt32 EnemyBufferSize
		{
			get => GetProperty(ref _enemyBufferSize);
			set => SetProperty(ref _enemyBufferSize, value);
		}

		[Ordinal(5)] 
		[RED("enemyLockNetwork")] 
		public ProgramData EnemyLockNetwork
		{
			get => GetProperty(ref _enemyLockNetwork);
			set => SetProperty(ref _enemyLockNetwork, value);
		}

		[Ordinal(6)] 
		[RED("enemyPrograms")] 
		public CArray<ProgramData> EnemyPrograms
		{
			get => GetProperty(ref _enemyPrograms);
			set => SetProperty(ref _enemyPrograms, value);
		}
	}
}
