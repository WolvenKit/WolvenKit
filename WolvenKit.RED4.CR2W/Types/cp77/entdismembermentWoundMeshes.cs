using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundMeshes : CVariable
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

		public entdismembermentWoundMeshes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
