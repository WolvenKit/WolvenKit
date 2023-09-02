using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentMeshInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(1)] 
		[RED("MeshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("AppearanceMap")] 
		public CArray<entdismembermentAppearanceMatch> AppearanceMap
		{
			get => GetPropertyValue<CArray<entdismembermentAppearanceMatch>>();
			set => SetPropertyValue<CArray<entdismembermentAppearanceMatch>>(value);
		}

		[Ordinal(3)] 
		[RED("ShouldReceiveDecal")] 
		public CBool ShouldReceiveDecal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("BodyPartMask")] 
		public CBitField<physicsRagdollBodyPartE> BodyPartMask
		{
			get => GetPropertyValue<CBitField<physicsRagdollBodyPartE>>();
			set => SetPropertyValue<CBitField<physicsRagdollBodyPartE>>(value);
		}

		[Ordinal(5)] 
		[RED("WoundType")] 
		public CBitField<entdismembermentWoundTypeE> WoundType
		{
			get => GetPropertyValue<CBitField<entdismembermentWoundTypeE>>();
			set => SetPropertyValue<CBitField<entdismembermentWoundTypeE>>(value);
		}

		[Ordinal(6)] 
		[RED("CullMesh")] 
		public CBitField<entdismembermentWoundTypeE> CullMesh
		{
			get => GetPropertyValue<CBitField<entdismembermentWoundTypeE>>();
			set => SetPropertyValue<CBitField<entdismembermentWoundTypeE>>(value);
		}

		[Ordinal(7)] 
		[RED("Offset")] 
		public Transform Offset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(8)] 
		[RED("Scale")] 
		public Vector3 Scale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(9)] 
		[RED("Physics")] 
		public entdismembermentPhysicsInfo Physics
		{
			get => GetPropertyValue<entdismembermentPhysicsInfo>();
			set => SetPropertyValue<entdismembermentPhysicsInfo>(value);
		}

		public entdismembermentMeshInfo()
		{
			MeshAppearance = "default";
			AppearanceMap = new();
			ShouldReceiveDecal = true;
			WoundType = Enums.entdismembermentWoundTypeE.CLEAN | Enums.entdismembermentWoundTypeE.COARSE;
			CullMesh = Enums.entdismembermentWoundTypeE.CLEAN;
			Offset = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			Scale = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			Physics = new entdismembermentPhysicsInfo { DensityScale = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
