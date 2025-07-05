using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterSpawnController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("enemyType")] 
		public CEnum<gameuiarcadeShooterAIType> EnemyType
		{
			get => GetPropertyValue<CEnum<gameuiarcadeShooterAIType>>();
			set => SetPropertyValue<CEnum<gameuiarcadeShooterAIType>>(value);
		}

		[Ordinal(2)] 
		[RED("spawnCondition")] 
		public CEnum<gameuiarcadeShooterSpawnerCondition> SpawnCondition
		{
			get => GetPropertyValue<CEnum<gameuiarcadeShooterSpawnerCondition>>();
			set => SetPropertyValue<CEnum<gameuiarcadeShooterSpawnerCondition>>(value);
		}

		[Ordinal(3)] 
		[RED("spawnDelay")] 
		public CFloat SpawnDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("spawnCount")] 
		public CUInt32 SpawnCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("offScreenSpawnExpiryTime")] 
		public CFloat OffScreenSpawnExpiryTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("skippable")] 
		public CBool Skippable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("skipOffset")] 
		public CFloat SkipOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("awaitPreviousUnitDead")] 
		public CBool AwaitPreviousUnitDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("enemyParameter")] 
		public CString EnemyParameter
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameuiarcadeShooterSpawnController()
		{
			SpawnDelay = 1.000000F;
			SpawnCount = 1;
			OffScreenSpawnExpiryTime = 3.000000F;
			Skippable = true;
			SkipOffset = 200.000000F;
			AwaitPreviousUnitDead = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
