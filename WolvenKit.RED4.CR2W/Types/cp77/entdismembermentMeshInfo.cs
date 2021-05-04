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
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(1)] 
		[RED("MeshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(2)] 
		[RED("AppearanceMap")] 
		public CArray<entdismembermentAppearanceMatch> AppearanceMap
		{
			get => GetProperty(ref _appearanceMap);
			set => SetProperty(ref _appearanceMap, value);
		}

		[Ordinal(3)] 
		[RED("ShouldReceiveDecal")] 
		public CBool ShouldReceiveDecal
		{
			get => GetProperty(ref _shouldReceiveDecal);
			set => SetProperty(ref _shouldReceiveDecal, value);
		}

		[Ordinal(4)] 
		[RED("BodyPartMask")] 
		public CEnum<physicsRagdollBodyPartE> BodyPartMask
		{
			get => GetProperty(ref _bodyPartMask);
			set => SetProperty(ref _bodyPartMask, value);
		}

		[Ordinal(5)] 
		[RED("WoundType")] 
		public CEnum<entdismembermentWoundTypeE> WoundType
		{
			get => GetProperty(ref _woundType);
			set => SetProperty(ref _woundType, value);
		}

		[Ordinal(6)] 
		[RED("CullMesh")] 
		public CEnum<entdismembermentWoundTypeE> CullMesh
		{
			get => GetProperty(ref _cullMesh);
			set => SetProperty(ref _cullMesh, value);
		}

		[Ordinal(7)] 
		[RED("Offset")] 
		public Transform Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(8)] 
		[RED("Scale")] 
		public Vector3 Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(9)] 
		[RED("Physics")] 
		public entdismembermentPhysicsInfo Physics
		{
			get => GetProperty(ref _physics);
			set => SetProperty(ref _physics, value);
		}

		public entdismembermentMeshInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
