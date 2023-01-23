using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentEffectResource : ISerializable
	{
		[Ordinal(0)] 
		[RED("Name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("AppearanceNames")] 
		public CArray<CName> AppearanceNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("BodyPartMask")] 
		public CBitField<physicsRagdollBodyPartE> BodyPartMask
		{
			get => GetPropertyValue<CBitField<physicsRagdollBodyPartE>>();
			set => SetPropertyValue<CBitField<physicsRagdollBodyPartE>>(value);
		}

		[Ordinal(3)] 
		[RED("Offset")] 
		public Transform Offset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(4)] 
		[RED("Placement")] 
		public CBitField<entdismembermentPlacementE> Placement
		{
			get => GetPropertyValue<CBitField<entdismembermentPlacementE>>();
			set => SetPropertyValue<CBitField<entdismembermentPlacementE>>(value);
		}

		[Ordinal(5)] 
		[RED("ResourceSets")] 
		public CBitField<entdismembermentResourceSetMask> ResourceSets
		{
			get => GetPropertyValue<CBitField<entdismembermentResourceSetMask>>();
			set => SetPropertyValue<CBitField<entdismembermentResourceSetMask>>(value);
		}

		[Ordinal(6)] 
		[RED("WoundType")] 
		public CBitField<entdismembermentWoundTypeE> WoundType
		{
			get => GetPropertyValue<CBitField<entdismembermentWoundTypeE>>();
			set => SetPropertyValue<CBitField<entdismembermentWoundTypeE>>(value);
		}

		[Ordinal(7)] 
		[RED("Effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(8)] 
		[RED("MatchToWoundByName")] 
		public CBool MatchToWoundByName
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entdismembermentEffectResource()
		{
			AppearanceNames = new();
			Offset = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			Placement = Enums.entdismembermentPlacementE.MAIN_MESH;
			ResourceSets = Enums.entdismembermentResourceSetMask.BARE | Enums.entdismembermentResourceSetMask.BARE1 | Enums.entdismembermentResourceSetMask.BARE2 | Enums.entdismembermentResourceSetMask.BARE3 | Enums.entdismembermentResourceSetMask.GARMENT | Enums.entdismembermentResourceSetMask.GARMENT1 | Enums.entdismembermentResourceSetMask.GARMENT2 | Enums.entdismembermentResourceSetMask.GARMENT3;
			WoundType = Enums.entdismembermentWoundTypeE.COARSE;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
