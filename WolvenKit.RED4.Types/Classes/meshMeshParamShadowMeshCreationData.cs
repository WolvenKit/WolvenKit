using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamShadowMeshCreationData : meshMeshParameter
	{
		private CArray<CHandle<physicsICollider>> _geometries;
		private CArray<CInt32> _bonesPerGeometry;

		[Ordinal(0)] 
		[RED("geometries")] 
		public CArray<CHandle<physicsICollider>> Geometries
		{
			get => GetProperty(ref _geometries);
			set => SetProperty(ref _geometries, value);
		}

		[Ordinal(1)] 
		[RED("bonesPerGeometry")] 
		public CArray<CInt32> BonesPerGeometry
		{
			get => GetProperty(ref _bonesPerGeometry);
			set => SetProperty(ref _bonesPerGeometry, value);
		}
	}
}
