using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioEnemyStateCountASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] 
		[RED("enemiesState")] 
		public CEnum<audioEnemyState> EnemiesState
		{
			get => GetPropertyValue<CEnum<audioEnemyState>>();
			set => SetPropertyValue<CEnum<audioEnemyState>>(value);
		}

		[Ordinal(2)] 
		[RED("countComparer")] 
		public CEnum<audioNumberComparer> CountComparer
		{
			get => GetPropertyValue<CEnum<audioNumberComparer>>();
			set => SetPropertyValue<CEnum<audioNumberComparer>>(value);
		}

		[Ordinal(3)] 
		[RED("enemiesCount")] 
		public CUInt32 EnemiesCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public audioEnemyStateCountASTCD()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
