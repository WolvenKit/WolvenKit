using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialSetupDesc : CVariable
	{
		private CArray<animImportFacialInitialPoseEntryDesc> _initialPose;
		private animImportFacialInitialControlsDesc _initialControls;
		private CArray<animImportFacialMainPoseDesc> _mainPoses;
		private CArray<animSermoPoseInfo> _mainPosesInfo;
		private CArray<CInt16> _jawAreaTrackIndices;
		private CArray<CInt16> _lipsAreaTrackIndices;
		private CArray<CInt16> _eyesAreaTrackIndices;
		private CUInt16 _numCachedPoseTracks;
		private CArray<animImportFacialCorrectivePoseDesc> _correctivePoses;
		private CArray<animPoseLimitWeights> _globalPoseLimits;
		private CUInt16 _wrinkleStartingIndex;
		private CArray<CUInt16> _wrinkleMapping;

		[Ordinal(0)] 
		[RED("initialPose")] 
		public CArray<animImportFacialInitialPoseEntryDesc> InitialPose
		{
			get => GetProperty(ref _initialPose);
			set => SetProperty(ref _initialPose, value);
		}

		[Ordinal(1)] 
		[RED("initialControls")] 
		public animImportFacialInitialControlsDesc InitialControls
		{
			get => GetProperty(ref _initialControls);
			set => SetProperty(ref _initialControls, value);
		}

		[Ordinal(2)] 
		[RED("mainPoses")] 
		public CArray<animImportFacialMainPoseDesc> MainPoses
		{
			get => GetProperty(ref _mainPoses);
			set => SetProperty(ref _mainPoses, value);
		}

		[Ordinal(3)] 
		[RED("mainPosesInfo")] 
		public CArray<animSermoPoseInfo> MainPosesInfo
		{
			get => GetProperty(ref _mainPosesInfo);
			set => SetProperty(ref _mainPosesInfo, value);
		}

		[Ordinal(4)] 
		[RED("jawAreaTrackIndices")] 
		public CArray<CInt16> JawAreaTrackIndices
		{
			get => GetProperty(ref _jawAreaTrackIndices);
			set => SetProperty(ref _jawAreaTrackIndices, value);
		}

		[Ordinal(5)] 
		[RED("lipsAreaTrackIndices")] 
		public CArray<CInt16> LipsAreaTrackIndices
		{
			get => GetProperty(ref _lipsAreaTrackIndices);
			set => SetProperty(ref _lipsAreaTrackIndices, value);
		}

		[Ordinal(6)] 
		[RED("eyesAreaTrackIndices")] 
		public CArray<CInt16> EyesAreaTrackIndices
		{
			get => GetProperty(ref _eyesAreaTrackIndices);
			set => SetProperty(ref _eyesAreaTrackIndices, value);
		}

		[Ordinal(7)] 
		[RED("numCachedPoseTracks")] 
		public CUInt16 NumCachedPoseTracks
		{
			get => GetProperty(ref _numCachedPoseTracks);
			set => SetProperty(ref _numCachedPoseTracks, value);
		}

		[Ordinal(8)] 
		[RED("correctivePoses")] 
		public CArray<animImportFacialCorrectivePoseDesc> CorrectivePoses
		{
			get => GetProperty(ref _correctivePoses);
			set => SetProperty(ref _correctivePoses, value);
		}

		[Ordinal(9)] 
		[RED("globalPoseLimits")] 
		public CArray<animPoseLimitWeights> GlobalPoseLimits
		{
			get => GetProperty(ref _globalPoseLimits);
			set => SetProperty(ref _globalPoseLimits, value);
		}

		[Ordinal(10)] 
		[RED("wrinkleStartingIndex")] 
		public CUInt16 WrinkleStartingIndex
		{
			get => GetProperty(ref _wrinkleStartingIndex);
			set => SetProperty(ref _wrinkleStartingIndex, value);
		}

		[Ordinal(11)] 
		[RED("wrinkleMapping")] 
		public CArray<CUInt16> WrinkleMapping
		{
			get => GetProperty(ref _wrinkleMapping);
			set => SetProperty(ref _wrinkleMapping, value);
		}

		public animImportFacialSetupDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
