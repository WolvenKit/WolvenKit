using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentMeshInfo : CVariable
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CArray<entdismembermentAppearanceMatch> _appearanceMap;
		private CBool _shouldReceiveDecal;
		private CEnum<physicsRagdollBodyPartE> _bodyPartMask;
		private CEnum<entdismembermentWoundTypeE> _woundType;
		private CEnum<entdismembermentWoundTypeE> _cullMesh;
		private Transform _offset;
		private Vector3 _scale;
		private entdismembermentPhysicsInfo _physics;

		[Ordinal(0)] 
		[RED("Mesh")] 
		public raRef<CMesh> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "Mesh", cr2w, this);
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

		[Ordinal(1)] 
		[RED("MeshAppearance")] 
		public CName MeshAppearance
		{
			get
			{
				if (_meshAppearance == null)
				{
					_meshAppearance = (CName) CR2WTypeManager.Create("CName", "MeshAppearance", cr2w, this);
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

		[Ordinal(2)] 
		[RED("AppearanceMap")] 
		public CArray<entdismembermentAppearanceMatch> AppearanceMap
		{
			get
			{
				if (_appearanceMap == null)
				{
					_appearanceMap = (CArray<entdismembermentAppearanceMatch>) CR2WTypeManager.Create("array:entdismembermentAppearanceMatch", "AppearanceMap", cr2w, this);
				}
				return _appearanceMap;
			}
			set
			{
				if (_appearanceMap == value)
				{
					return;
				}
				_appearanceMap = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ShouldReceiveDecal")] 
		public CBool ShouldReceiveDecal
		{
			get
			{
				if (_shouldReceiveDecal == null)
				{
					_shouldReceiveDecal = (CBool) CR2WTypeManager.Create("Bool", "ShouldReceiveDecal", cr2w, this);
				}
				return _shouldReceiveDecal;
			}
			set
			{
				if (_shouldReceiveDecal == value)
				{
					return;
				}
				_shouldReceiveDecal = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("BodyPartMask")] 
		public CEnum<physicsRagdollBodyPartE> BodyPartMask
		{
			get
			{
				if (_bodyPartMask == null)
				{
					_bodyPartMask = (CEnum<physicsRagdollBodyPartE>) CR2WTypeManager.Create("physicsRagdollBodyPartE", "BodyPartMask", cr2w, this);
				}
				return _bodyPartMask;
			}
			set
			{
				if (_bodyPartMask == value)
				{
					return;
				}
				_bodyPartMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("WoundType")] 
		public CEnum<entdismembermentWoundTypeE> WoundType
		{
			get
			{
				if (_woundType == null)
				{
					_woundType = (CEnum<entdismembermentWoundTypeE>) CR2WTypeManager.Create("entdismembermentWoundTypeE", "WoundType", cr2w, this);
				}
				return _woundType;
			}
			set
			{
				if (_woundType == value)
				{
					return;
				}
				_woundType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("CullMesh")] 
		public CEnum<entdismembermentWoundTypeE> CullMesh
		{
			get
			{
				if (_cullMesh == null)
				{
					_cullMesh = (CEnum<entdismembermentWoundTypeE>) CR2WTypeManager.Create("entdismembermentWoundTypeE", "CullMesh", cr2w, this);
				}
				return _cullMesh;
			}
			set
			{
				if (_cullMesh == value)
				{
					return;
				}
				_cullMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Offset")] 
		public Transform Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Transform) CR2WTypeManager.Create("Transform", "Offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("Scale")] 
		public Vector3 Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (Vector3) CR2WTypeManager.Create("Vector3", "Scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Physics")] 
		public entdismembermentPhysicsInfo Physics
		{
			get
			{
				if (_physics == null)
				{
					_physics = (entdismembermentPhysicsInfo) CR2WTypeManager.Create("entdismembermentPhysicsInfo", "Physics", cr2w, this);
				}
				return _physics;
			}
			set
			{
				if (_physics == value)
				{
					return;
				}
				_physics = value;
				PropertySet(this);
			}
		}

		public entdismembermentMeshInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
