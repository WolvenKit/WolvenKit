using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MorphTargetMeshEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("regionName")] 
		public CName RegionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("faceRegion")] 
		public CEnum<MorphTargetsFaceRegion> FaceRegion
		{
			get => GetPropertyValue<CEnum<MorphTargetsFaceRegion>>();
			set => SetPropertyValue<CEnum<MorphTargetsFaceRegion>>(value);
		}

		[Ordinal(3)] 
		[RED("boneNames")] 
		public CArray<CName> BoneNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("boneRigMatrices")] 
		public CArray<CMatrix> BoneRigMatrices
		{
			get => GetPropertyValue<CArray<CMatrix>>();
			set => SetPropertyValue<CArray<CMatrix>>(value);
		}

		public MorphTargetMeshEntry()
		{
			FaceRegion = Enums.MorphTargetsFaceRegion.FACE_REGION_NONE;
			BoneNames = new();
			BoneRigMatrices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
