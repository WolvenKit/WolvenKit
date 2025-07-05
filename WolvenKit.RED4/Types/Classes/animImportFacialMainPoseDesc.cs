using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animImportFacialMainPoseDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("influencedBy")] 
		public CArray<CName> InfluencedBy
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("influenceMainWeightIndices")] 
		public CArray<CUInt16> InfluenceMainWeightIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(2)] 
		[RED("poses")] 
		public CArray<animImportFacialPoseDesc> Poses
		{
			get => GetPropertyValue<CArray<animImportFacialPoseDesc>>();
			set => SetPropertyValue<CArray<animImportFacialPoseDesc>>(value);
		}

		[Ordinal(3)] 
		[RED("poseIndices")] 
		public CArray<CUInt16> PoseIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(4)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("inBetweenScopeMultipliers")] 
		public CArray<CFloat> InBetweenScopeMultipliers
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(8)] 
		[RED("influenceType")] 
		public CUInt8 InfluenceType
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(9)] 
		[RED("side")] 
		public CUInt8 Side
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(10)] 
		[RED("facePart")] 
		public CUInt8 FacePart
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public animImportFacialMainPoseDesc()
		{
			InfluencedBy = new();
			InfluenceMainWeightIndices = new();
			Poses = new();
			PoseIndices = new();
			Weights = new();
			InBetweenScopeMultipliers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
