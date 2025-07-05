using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPhysicalDestructionNode : worldNode
	{
		[Ordinal(4)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(5)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("forceLODLevel")] 
		public CInt32 ForceLODLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get => GetPropertyValue<physicsDestructionParams>();
			set => SetPropertyValue<physicsDestructionParams>(value);
		}

		[Ordinal(9)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get => GetPropertyValue<CArray<physicsDestructionLevelData>>();
			set => SetPropertyValue<CArray<physicsDestructionLevelData>>(value);
		}

		[Ordinal(10)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		[Ordinal(12)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("systemsToNotifyFlags")] 
		public CUInt16 SystemsToNotifyFlags
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public worldPhysicalDestructionNode()
		{
			MeshAppearance = "default";
			ForceLODLevel = -1;
			DestructionParams = new physicsDestructionParams { DamageThreshold = 25.000000F, DamageEndurance = 10.000000F, BondEndurance = 20.000000F, AccumulateDamage = true, EnableImpulseDamage = true, ImpulseToDamage = 1.000000F, ContactToDamage = 10.000000F, MaxContactImpulseRatio = 1.000000F, ImpulseChildPropagationFactor = 1.000000F, ImpulsePropagationFactor = 0.500000F, ImpulseDiminishingFactor = 0.500000F, DebrisMaxSeparation = 50.000000F, MaxAngularVelocity = -1.000000F, FractureFieldMask = Enums.physicsFractureFieldType.FF_Default };
			DestructionLevelData = new();
			NavigationSetting = new NavGenNavigationSetting { NavmeshImpact = Enums.NavGenNavmeshImpact.Blocking };
			UseMeshNavmeshSettings = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
