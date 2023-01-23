using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animImportFacialSetupDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("initialPose")] 
		public CArray<animImportFacialInitialPoseEntryDesc> InitialPose
		{
			get => GetPropertyValue<CArray<animImportFacialInitialPoseEntryDesc>>();
			set => SetPropertyValue<CArray<animImportFacialInitialPoseEntryDesc>>(value);
		}

		[Ordinal(1)] 
		[RED("initialControls")] 
		public animImportFacialInitialControlsDesc InitialControls
		{
			get => GetPropertyValue<animImportFacialInitialControlsDesc>();
			set => SetPropertyValue<animImportFacialInitialControlsDesc>(value);
		}

		[Ordinal(2)] 
		[RED("mainPoses")] 
		public CArray<animImportFacialMainPoseDesc> MainPoses
		{
			get => GetPropertyValue<CArray<animImportFacialMainPoseDesc>>();
			set => SetPropertyValue<CArray<animImportFacialMainPoseDesc>>(value);
		}

		[Ordinal(3)] 
		[RED("mainPosesInfo")] 
		public CArray<animSermoPoseInfo> MainPosesInfo
		{
			get => GetPropertyValue<CArray<animSermoPoseInfo>>();
			set => SetPropertyValue<CArray<animSermoPoseInfo>>(value);
		}

		[Ordinal(4)] 
		[RED("jawAreaTrackIndices")] 
		public CArray<CInt16> JawAreaTrackIndices
		{
			get => GetPropertyValue<CArray<CInt16>>();
			set => SetPropertyValue<CArray<CInt16>>(value);
		}

		[Ordinal(5)] 
		[RED("lipsAreaTrackIndices")] 
		public CArray<CInt16> LipsAreaTrackIndices
		{
			get => GetPropertyValue<CArray<CInt16>>();
			set => SetPropertyValue<CArray<CInt16>>(value);
		}

		[Ordinal(6)] 
		[RED("eyesAreaTrackIndices")] 
		public CArray<CInt16> EyesAreaTrackIndices
		{
			get => GetPropertyValue<CArray<CInt16>>();
			set => SetPropertyValue<CArray<CInt16>>(value);
		}

		[Ordinal(7)] 
		[RED("numCachedPoseTracks")] 
		public CUInt16 NumCachedPoseTracks
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(8)] 
		[RED("correctivePoses")] 
		public CArray<animImportFacialCorrectivePoseDesc> CorrectivePoses
		{
			get => GetPropertyValue<CArray<animImportFacialCorrectivePoseDesc>>();
			set => SetPropertyValue<CArray<animImportFacialCorrectivePoseDesc>>(value);
		}

		[Ordinal(9)] 
		[RED("globalPoseLimits")] 
		public CArray<animPoseLimitWeights> GlobalPoseLimits
		{
			get => GetPropertyValue<CArray<animPoseLimitWeights>>();
			set => SetPropertyValue<CArray<animPoseLimitWeights>>(value);
		}

		[Ordinal(10)] 
		[RED("wrinkleStartingIndex")] 
		public CUInt16 WrinkleStartingIndex
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(11)] 
		[RED("wrinkleMapping")] 
		public CArray<CUInt16> WrinkleMapping
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		public animImportFacialSetupDesc()
		{
			InitialPose = new();
			InitialControls = new() { TransformIds = new(), TransformNames = new(), TransformRegions = new() };
			MainPoses = new();
			MainPosesInfo = new();
			JawAreaTrackIndices = new();
			LipsAreaTrackIndices = new();
			EyesAreaTrackIndices = new();
			CorrectivePoses = new();
			GlobalPoseLimits = new();
			WrinkleMapping = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
