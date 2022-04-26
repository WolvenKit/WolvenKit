using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentWoundResource : ISerializable
	{
		[Ordinal(0)] 
		[RED("Name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("WoundType")] 
		public CBitField<entdismembermentWoundTypeE> WoundType
		{
			get => GetPropertyValue<CBitField<entdismembermentWoundTypeE>>();
			set => SetPropertyValue<CBitField<entdismembermentWoundTypeE>>(value);
		}

		[Ordinal(2)] 
		[RED("BodyPart")] 
		public CBitField<physicsRagdollBodyPartE> BodyPart
		{
			get => GetPropertyValue<CBitField<physicsRagdollBodyPartE>>();
			set => SetPropertyValue<CBitField<physicsRagdollBodyPartE>>(value);
		}

		[Ordinal(3)] 
		[RED("CullObject")] 
		public entdismembermentCullObject CullObject
		{
			get => GetPropertyValue<entdismembermentCullObject>();
			set => SetPropertyValue<entdismembermentCullObject>(value);
		}

		[Ordinal(4)] 
		[RED("GarmentMorphStrength")] 
		public CFloat GarmentMorphStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("UseProceduralCut")] 
		public CBool UseProceduralCut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("UseSingleMeshForRagdoll")] 
		public CBool UseSingleMeshForRagdoll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("IsCritical")] 
		public CBool IsCritical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("Resources")] 
		public CArray<entdismembermentWoundMeshes> Resources
		{
			get => GetPropertyValue<CArray<entdismembermentWoundMeshes>>();
			set => SetPropertyValue<CArray<entdismembermentWoundMeshes>>(value);
		}

		[Ordinal(9)] 
		[RED("Decals")] 
		public CArray<entdismembermentWoundDecal> Decals
		{
			get => GetPropertyValue<CArray<entdismembermentWoundDecal>>();
			set => SetPropertyValue<CArray<entdismembermentWoundDecal>>(value);
		}

		[Ordinal(10)] 
		[RED("CensoredPaths")] 
		public CArray<CUInt64> CensoredPaths
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(11)] 
		[RED("CensoredCookedPaths")] 
		public CArray<CResourceAsyncReference<CResource>> CensoredCookedPaths
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}

		[Ordinal(12)] 
		[RED("CensorshipValid")] 
		public CBool CensorshipValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entdismembermentWoundResource()
		{
			WoundType = Enums.entdismembermentWoundTypeE.CLEAN | Enums.entdismembermentWoundTypeE.COARSE;
			CullObject = new() { Plane = new() { NormalDistance = new() { Z = 1.000000F, W = -0.000000F } }, Plane1 = new() { NormalDistance = new() { Z = 1.000000F, W = -0.000000F } }, CapsulePointA = new(), CapsulePointB = new(), CapsuleRadius = 0.100000F, NearestAnimIndex = -1, RagdollBodyIndex = 65535 };
			GarmentMorphStrength = 1.000000F;
			Resources = new();
			Decals = new();
			CensoredPaths = new();
			CensoredCookedPaths = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
