using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StuckInEffector : gameContinuousEffector
	{
		[Ordinal(0)] 
		[RED("maxEnemyDistance")] 
		public CFloat MaxEnemyDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("enemyCount")] 
		public CInt32 EnemyCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public StuckInEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
