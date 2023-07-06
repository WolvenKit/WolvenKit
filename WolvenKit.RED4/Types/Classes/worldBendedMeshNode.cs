using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldBendedMeshNode : worldNode
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
		[RED("deformationData")] 
		public CArray<CMatrix> DeformationData
		{
			get => GetPropertyValue<CArray<CMatrix>>();
			set => SetPropertyValue<CArray<CMatrix>>(value);
		}

		[Ordinal(7)] 
		[RED("deformedBox")] 
		public Box DeformedBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(8)] 
		[RED("isBendedRoad")] 
		public CBool IsBendedRoad
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("removeFromRainMap")] 
		public CBool RemoveFromRainMap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		public worldBendedMeshNode()
		{
			MeshAppearance = "default";
			DeformationData = new();
			DeformedBox = new Box { Min = new Vector4(), Max = new Vector4() };
			CastShadows = true;
			CastLocalShadows = true;
			NavigationSetting = new NavGenNavigationSetting { NavmeshImpact = Enums.NavGenNavmeshImpact.Blocking };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
