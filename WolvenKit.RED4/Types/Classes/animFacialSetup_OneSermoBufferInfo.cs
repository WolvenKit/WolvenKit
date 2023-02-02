using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialSetup_OneSermoBufferInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("numGlobalLimits")] 
		public CUInt16 NumGlobalLimits
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("numInfluencedPoses")] 
		public CUInt16 NumInfluencedPoses
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("numInfluenceIndices")] 
		public CUInt16 NumInfluenceIndices
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(3)] 
		[RED("numUpperLowerFace")] 
		public CUInt16 NumUpperLowerFace
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(4)] 
		[RED("numLipsyncPosesSides")] 
		public CUInt16 NumLipsyncPosesSides
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(5)] 
		[RED("numAllCorrectives")] 
		public CUInt16 NumAllCorrectives
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(6)] 
		[RED("numGlobalCorrectiveEntries")] 
		public CUInt16 NumGlobalCorrectiveEntries
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(7)] 
		[RED("numInbetweenCorrectiveEntries")] 
		public CUInt16 NumInbetweenCorrectiveEntries
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(8)] 
		[RED("numCorrectiveInfluencedPoses")] 
		public CUInt16 NumCorrectiveInfluencedPoses
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(9)] 
		[RED("numCorrectiveInfluenceIndices")] 
		public CUInt16 NumCorrectiveInfluenceIndices
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(10)] 
		[RED("numAllMainPoses")] 
		public CUInt16 NumAllMainPoses
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(11)] 
		[RED("numAllMainPosesInbetweens")] 
		public CUInt16 NumAllMainPosesInbetweens
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(12)] 
		[RED("numAllMainPosesInbetweenScopeMultipliers")] 
		public CUInt16 NumAllMainPosesInbetweenScopeMultipliers
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(13)] 
		[RED("numEnvelopesPerTrackMapping")] 
		public CUInt16 NumEnvelopesPerTrackMapping
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(14)] 
		[RED("wrinkleStartingIndex")] 
		public CUInt16 WrinkleStartingIndex
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(15)] 
		[RED("numWrinkles")] 
		public CUInt16 NumWrinkles
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public animFacialSetup_OneSermoBufferInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
