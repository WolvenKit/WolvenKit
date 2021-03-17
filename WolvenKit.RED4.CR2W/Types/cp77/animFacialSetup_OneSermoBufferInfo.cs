using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_OneSermoBufferInfo : CVariable
	{
		private CUInt16 _numGlobalLimits;
		private CUInt16 _numInfluencedPoses;
		private CUInt16 _numInfluenceIndices;
		private CUInt16 _numUpperLowerFace;
		private CUInt16 _numLipsyncPosesSides;
		private CUInt16 _numAllCorrectives;
		private CUInt16 _numGlobalCorrectiveEntries;
		private CUInt16 _numInbetweenCorrectiveEntries;
		private CUInt16 _numCorrectiveInfluencedPoses;
		private CUInt16 _numCorrectiveInfluenceIndices;
		private CUInt16 _numAllMainPoses;
		private CUInt16 _numAllMainPosesInbetweens;
		private CUInt16 _numAllMainPosesInbetweenScopeMultipliers;
		private CUInt16 _numEnvelopesPerTrackMapping;
		private CUInt16 _wrinkleStartingIndex;
		private CUInt16 _numWrinkles;

		[Ordinal(0)] 
		[RED("numGlobalLimits")] 
		public CUInt16 NumGlobalLimits
		{
			get => GetProperty(ref _numGlobalLimits);
			set => SetProperty(ref _numGlobalLimits, value);
		}

		[Ordinal(1)] 
		[RED("numInfluencedPoses")] 
		public CUInt16 NumInfluencedPoses
		{
			get => GetProperty(ref _numInfluencedPoses);
			set => SetProperty(ref _numInfluencedPoses, value);
		}

		[Ordinal(2)] 
		[RED("numInfluenceIndices")] 
		public CUInt16 NumInfluenceIndices
		{
			get => GetProperty(ref _numInfluenceIndices);
			set => SetProperty(ref _numInfluenceIndices, value);
		}

		[Ordinal(3)] 
		[RED("numUpperLowerFace")] 
		public CUInt16 NumUpperLowerFace
		{
			get => GetProperty(ref _numUpperLowerFace);
			set => SetProperty(ref _numUpperLowerFace, value);
		}

		[Ordinal(4)] 
		[RED("numLipsyncPosesSides")] 
		public CUInt16 NumLipsyncPosesSides
		{
			get => GetProperty(ref _numLipsyncPosesSides);
			set => SetProperty(ref _numLipsyncPosesSides, value);
		}

		[Ordinal(5)] 
		[RED("numAllCorrectives")] 
		public CUInt16 NumAllCorrectives
		{
			get => GetProperty(ref _numAllCorrectives);
			set => SetProperty(ref _numAllCorrectives, value);
		}

		[Ordinal(6)] 
		[RED("numGlobalCorrectiveEntries")] 
		public CUInt16 NumGlobalCorrectiveEntries
		{
			get => GetProperty(ref _numGlobalCorrectiveEntries);
			set => SetProperty(ref _numGlobalCorrectiveEntries, value);
		}

		[Ordinal(7)] 
		[RED("numInbetweenCorrectiveEntries")] 
		public CUInt16 NumInbetweenCorrectiveEntries
		{
			get => GetProperty(ref _numInbetweenCorrectiveEntries);
			set => SetProperty(ref _numInbetweenCorrectiveEntries, value);
		}

		[Ordinal(8)] 
		[RED("numCorrectiveInfluencedPoses")] 
		public CUInt16 NumCorrectiveInfluencedPoses
		{
			get => GetProperty(ref _numCorrectiveInfluencedPoses);
			set => SetProperty(ref _numCorrectiveInfluencedPoses, value);
		}

		[Ordinal(9)] 
		[RED("numCorrectiveInfluenceIndices")] 
		public CUInt16 NumCorrectiveInfluenceIndices
		{
			get => GetProperty(ref _numCorrectiveInfluenceIndices);
			set => SetProperty(ref _numCorrectiveInfluenceIndices, value);
		}

		[Ordinal(10)] 
		[RED("numAllMainPoses")] 
		public CUInt16 NumAllMainPoses
		{
			get => GetProperty(ref _numAllMainPoses);
			set => SetProperty(ref _numAllMainPoses, value);
		}

		[Ordinal(11)] 
		[RED("numAllMainPosesInbetweens")] 
		public CUInt16 NumAllMainPosesInbetweens
		{
			get => GetProperty(ref _numAllMainPosesInbetweens);
			set => SetProperty(ref _numAllMainPosesInbetweens, value);
		}

		[Ordinal(12)] 
		[RED("numAllMainPosesInbetweenScopeMultipliers")] 
		public CUInt16 NumAllMainPosesInbetweenScopeMultipliers
		{
			get => GetProperty(ref _numAllMainPosesInbetweenScopeMultipliers);
			set => SetProperty(ref _numAllMainPosesInbetweenScopeMultipliers, value);
		}

		[Ordinal(13)] 
		[RED("numEnvelopesPerTrackMapping")] 
		public CUInt16 NumEnvelopesPerTrackMapping
		{
			get => GetProperty(ref _numEnvelopesPerTrackMapping);
			set => SetProperty(ref _numEnvelopesPerTrackMapping, value);
		}

		[Ordinal(14)] 
		[RED("wrinkleStartingIndex")] 
		public CUInt16 WrinkleStartingIndex
		{
			get => GetProperty(ref _wrinkleStartingIndex);
			set => SetProperty(ref _wrinkleStartingIndex, value);
		}

		[Ordinal(15)] 
		[RED("numWrinkles")] 
		public CUInt16 NumWrinkles
		{
			get => GetProperty(ref _numWrinkles);
			set => SetProperty(ref _numWrinkles, value);
		}

		public animFacialSetup_OneSermoBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
