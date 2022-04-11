using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animImportFacialCorrectivePoseDesc : RedBaseClass
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
		public CArray<animImportFacialCorrectivePoseDataDesc> Poses
		{
			get => GetPropertyValue<CArray<animImportFacialCorrectivePoseDataDesc>>();
			set => SetPropertyValue<CArray<animImportFacialCorrectivePoseDataDesc>>(value);
		}

		[Ordinal(3)] 
		[RED("parentsInBetweenIndices")] 
		public CArray<CInt16> ParentsInBetweenIndices
		{
			get => GetPropertyValue<CArray<CInt16>>();
			set => SetPropertyValue<CArray<CInt16>>(value);
		}

		[Ordinal(4)] 
		[RED("parentIndices")] 
		public CArray<CUInt16> ParentIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(5)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(7)] 
		[RED("influencedBySpeed")] 
		public CUInt8 InfluencedBySpeed
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(8)] 
		[RED("poseType")] 
		public CUInt8 PoseType
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(9)] 
		[RED("poseLOD")] 
		public CUInt8 PoseLOD
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(10)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(11)] 
		[RED("inBetweenScopeMultipliers")] 
		public CArray<CFloat> InBetweenScopeMultipliers
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(12)] 
		[RED("linearCorrection")] 
		public CBool LinearCorrection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("useGlobalWeight")] 
		public CBool UseGlobalWeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animImportFacialCorrectivePoseDesc()
		{
			InfluencedBy = new();
			InfluenceMainWeightIndices = new();
			Poses = new();
			ParentsInBetweenIndices = new();
			ParentIndices = new();
			Weights = new();
			InBetweenScopeMultipliers = new();
			UseGlobalWeight = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
