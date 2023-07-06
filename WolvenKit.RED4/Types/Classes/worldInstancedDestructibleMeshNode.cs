using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldInstancedDestructibleMeshNode : worldMeshNode
	{
		[Ordinal(1000)] 
		[RED("staticMesh")] 
		public CResourceAsyncReference<CMesh> StaticMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(1001)] 
		[RED("staticMeshAppearance")] 
		public CName StaticMeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1002)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetPropertyValue<CEnum<physicsSimulationType>>();
			set => SetPropertyValue<CEnum<physicsSimulationType>>(value);
		}

		[Ordinal(1003)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetPropertyValue<CEnum<physicsFilterDataSource>>();
			set => SetPropertyValue<CEnum<physicsFilterDataSource>>(value);
		}

		[Ordinal(1004)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1005)] 
		[RED("turnDynamicOnImpulse")] 
		public CBool TurnDynamicOnImpulse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1006)] 
		[RED("useAggregate")] 
		public CBool UseAggregate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1007)] 
		[RED("enableSelfCollisionInAggregate")] 
		public CBool EnableSelfCollisionInAggregate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1008)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1009)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(1010)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1011)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1012)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1013)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1014)] 
		[RED("fracturingEffect")] 
		public CResourceAsyncReference<worldEffect> FracturingEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(1015)] 
		[RED("idleEffect")] 
		public CResourceAsyncReference<worldEffect> IdleEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(1016)] 
		[RED("instanceTransforms")] 
		public CArray<Transform> InstanceTransforms
		{
			get => GetPropertyValue<CArray<Transform>>();
			set => SetPropertyValue<CArray<Transform>>(value);
		}

		[Ordinal(1017)] 
		[RED("cookedInstanceTransforms")] 
		public worldTransformBuffer CookedInstanceTransforms
		{
			get => GetPropertyValue<worldTransformBuffer>();
			set => SetPropertyValue<worldTransformBuffer>(value);
		}

		[Ordinal(1018)] 
		[RED("isPierceable")] 
		public CBool IsPierceable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1019)] 
		[RED("isWorkspot")] 
		public CBool IsWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1020)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		[Ordinal(1021)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1022)] 
		[RED("systemsToNotifyFlags")] 
		public CUInt16 SystemsToNotifyFlags
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public worldInstancedDestructibleMeshNode()
		{
			SimulationType = Enums.physicsSimulationType.Dynamic;
			StartInactive = true;
			DamageThreshold = 1.000000F;
			DamageEndurance = 10.000000F;
			AccumulateDamage = true;
			ImpulseToDamage = 1.000000F;
			InstanceTransforms = new();
			CookedInstanceTransforms = new worldTransformBuffer();
			NavigationSetting = new NavGenNavigationSetting { NavmeshImpact = Enums.NavGenNavmeshImpact.Blocking };
			UseMeshNavmeshSettings = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
