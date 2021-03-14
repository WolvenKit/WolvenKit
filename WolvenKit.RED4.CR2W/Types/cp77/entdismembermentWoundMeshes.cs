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
			get
			{
				if (_resourceSet == null)
				{
					_resourceSet = (CEnum<entdismembermentResourceSetE>) CR2WTypeManager.Create("entdismembermentResourceSetE", "ResourceSet", cr2w, this);
				}
				return _resourceSet;
			}
			set
			{
				if (_resourceSet == value)
				{
					return;
				}
				_resourceSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Meshes")] 
		public CArray<entdismembermentMeshInfo> Meshes
		{
			get
			{
				if (_meshes == null)
				{
					_meshes = (CArray<entdismembermentMeshInfo>) CR2WTypeManager.Create("array:entdismembermentMeshInfo", "Meshes", cr2w, this);
				}
				return _meshes;
			}
			set
			{
				if (_meshes == value)
				{
					return;
				}
				_meshes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("FillMeshes")] 
		public CArray<entdismembermentFillMeshInfo> FillMeshes
		{
			get
			{
				if (_fillMeshes == null)
				{
					_fillMeshes = (CArray<entdismembermentFillMeshInfo>) CR2WTypeManager.Create("array:entdismembermentFillMeshInfo", "FillMeshes", cr2w, this);
				}
				return _fillMeshes;
			}
			set
			{
				if (_fillMeshes == value)
				{
					return;
				}
				_fillMeshes = value;
				PropertySet(this);
			}
		}

		public entdismembermentWoundMeshes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
