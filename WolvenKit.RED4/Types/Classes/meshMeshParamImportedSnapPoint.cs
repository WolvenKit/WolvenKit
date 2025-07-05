using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamImportedSnapPoint : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("snapFeatureData")] 
		public CArray<CHandle<meshMeshImportedSnapPoint>> SnapFeatureData
		{
			get => GetPropertyValue<CArray<CHandle<meshMeshImportedSnapPoint>>>();
			set => SetPropertyValue<CArray<CHandle<meshMeshImportedSnapPoint>>>(value);
		}

		public meshMeshParamImportedSnapPoint()
		{
			SnapFeatureData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
