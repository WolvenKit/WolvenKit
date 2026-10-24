using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPhysicalDestructionNode : worldNode
	{
		[Ordinal(2)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(3)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("forceLODLevel")] 
		public CInt32 ForceLODLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get => GetPropertyValue<physicsDestructionParams>();
			set => SetPropertyValue<physicsDestructionParams>(value);
		}

		[Ordinal(7)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get => GetPropertyValue<CArray<physicsDestructionLevelData>>();
			set => SetPropertyValue<CArray<physicsDestructionLevelData>>(value);
		}

		[Ordinal(8)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		[Ordinal(10)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
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
			DestructionParams = new physicsDestructionParams();
			DestructionLevelData = new();
			NavigationSetting = new NavGenNavigationSetting();
			UseMeshNavmeshSettings = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
