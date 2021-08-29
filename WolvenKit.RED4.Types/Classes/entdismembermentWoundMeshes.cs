using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentWoundMeshes : RedBaseClass
	{
		private CEnum<entdismembermentResourceSetE> _resourceSet;
		private CArray<entdismembermentMeshInfo> _meshes;
		private CArray<entdismembermentFillMeshInfo> _fillMeshes;

		[Ordinal(0)] 
		[RED("ResourceSet")] 
		public CEnum<entdismembermentResourceSetE> ResourceSet
		{
			get => GetProperty(ref _resourceSet);
			set => SetProperty(ref _resourceSet, value);
		}

		[Ordinal(1)] 
		[RED("Meshes")] 
		public CArray<entdismembermentMeshInfo> Meshes
		{
			get => GetProperty(ref _meshes);
			set => SetProperty(ref _meshes, value);
		}

		[Ordinal(2)] 
		[RED("FillMeshes")] 
		public CArray<entdismembermentFillMeshInfo> FillMeshes
		{
			get => GetProperty(ref _fillMeshes);
			set => SetProperty(ref _fillMeshes, value);
		}
	}
}
