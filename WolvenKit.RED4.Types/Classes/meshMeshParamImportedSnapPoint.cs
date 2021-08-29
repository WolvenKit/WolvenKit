using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamImportedSnapPoint : meshMeshParameter
	{
		private CArray<CHandle<meshMeshImportedSnapPoint>> _snapFeatureData;

		[Ordinal(0)] 
		[RED("snapFeatureData")] 
		public CArray<CHandle<meshMeshImportedSnapPoint>> SnapFeatureData
		{
			get => GetProperty(ref _snapFeatureData);
			set => SetProperty(ref _snapFeatureData, value);
		}
	}
}
