using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageDestructionMapping : ISerializable
	{
		private raRef<CMesh> _baseMesh;
		private raRef<CMesh> _destructibleMesh;
		private CName _meshAppearance;

		[Ordinal(0)] 
		[RED("baseMesh")] 
		public raRef<CMesh> BaseMesh
		{
			get
			{
				if (_baseMesh == null)
				{
					_baseMesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "baseMesh", cr2w, this);
				}
				return _baseMesh;
			}
			set
			{
				if (_baseMesh == value)
				{
					return;
				}
				_baseMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("destructibleMesh")] 
		public raRef<CMesh> DestructibleMesh
		{
			get
			{
				if (_destructibleMesh == null)
				{
					_destructibleMesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "destructibleMesh", cr2w, this);
				}
				return _destructibleMesh;
			}
			set
			{
				if (_destructibleMesh == value)
				{
					return;
				}
				_destructibleMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get
			{
				if (_meshAppearance == null)
				{
					_meshAppearance = (CName) CR2WTypeManager.Create("CName", "meshAppearance", cr2w, this);
				}
				return _meshAppearance;
			}
			set
			{
				if (_meshAppearance == value)
				{
					return;
				}
				_meshAppearance = value;
				PropertySet(this);
			}
		}

		public worldFoliageDestructionMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
