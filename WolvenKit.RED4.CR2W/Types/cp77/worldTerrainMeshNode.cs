using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTerrainMeshNode : worldNode
	{
		private CHandle<CMesh> _mesh;
		private raRef<CMesh> _meshRef;

		[Ordinal(4)] 
		[RED("mesh")] 
		public CHandle<CMesh> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (CHandle<CMesh>) CR2WTypeManager.Create("handle:CMesh", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("meshRef")] 
		public raRef<CMesh> MeshRef
		{
			get
			{
				if (_meshRef == null)
				{
					_meshRef = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "meshRef", cr2w, this);
				}
				return _meshRef;
			}
			set
			{
				if (_meshRef == value)
				{
					return;
				}
				_meshRef = value;
				PropertySet(this);
			}
		}

		public worldTerrainMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
