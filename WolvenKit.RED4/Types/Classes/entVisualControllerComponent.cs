using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entVisualControllerComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("meshProxy")] 
		public CResourceReference<CMesh> MeshProxy
		{
			get => GetPropertyValue<CResourceReference<CMesh>>();
			set => SetPropertyValue<CResourceReference<CMesh>>(value);
		}

		[Ordinal(4)] 
		[RED("appearanceDependency")] 
		public CArray<entVisualControllerDependency> AppearanceDependency
		{
			get => GetPropertyValue<CArray<entVisualControllerDependency>>();
			set => SetPropertyValue<CArray<entVisualControllerDependency>>(value);
		}

		[Ordinal(5)] 
		[RED("cookedAppearanceData")] 
		public CResourceAsyncReference<appearanceCookedAppearanceData> CookedAppearanceData
		{
			get => GetPropertyValue<CResourceAsyncReference<appearanceCookedAppearanceData>>();
			set => SetPropertyValue<CResourceAsyncReference<appearanceCookedAppearanceData>>(value);
		}

		[Ordinal(6)] 
		[RED("forcedLodDistance")] 
		public CEnum<entForcedLodDistance> ForcedLodDistance
		{
			get => GetPropertyValue<CEnum<entForcedLodDistance>>();
			set => SetPropertyValue<CEnum<entForcedLodDistance>>(value);
		}

		public entVisualControllerComponent()
		{
			Name = "Component";
			AppearanceDependency = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
