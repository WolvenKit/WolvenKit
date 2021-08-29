using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEnemyStateCountASTCD : audioAudioStateTransitionConditionData
	{
		private CEnum<audioEnemyState> _enemiesState;
		private CEnum<audioNumberComparer> _countComparer;
		private CUInt32 _enemiesCount;

		[Ordinal(1)] 
		[RED("enemiesState")] 
		public CEnum<audioEnemyState> EnemiesState
		{
			get => GetProperty(ref _enemiesState);
			set => SetProperty(ref _enemiesState, value);
		}

		[Ordinal(2)] 
		[RED("countComparer")] 
		public CEnum<audioNumberComparer> CountComparer
		{
			get => GetProperty(ref _countComparer);
			set => SetProperty(ref _countComparer, value);
		}

		[Ordinal(3)] 
		[RED("enemiesCount")] 
		public CUInt32 EnemiesCount
		{
			get => GetProperty(ref _enemiesCount);
			set => SetProperty(ref _enemiesCount, value);
		}
	}
}
