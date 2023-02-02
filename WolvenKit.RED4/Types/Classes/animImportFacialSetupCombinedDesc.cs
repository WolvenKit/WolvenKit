using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animImportFacialSetupCombinedDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("face")] 
		public animImportFacialSetupDesc Face
		{
			get => GetPropertyValue<animImportFacialSetupDesc>();
			set => SetPropertyValue<animImportFacialSetupDesc>(value);
		}

		[Ordinal(1)] 
		[RED("eyes")] 
		public animImportFacialSetupDesc Eyes
		{
			get => GetPropertyValue<animImportFacialSetupDesc>();
			set => SetPropertyValue<animImportFacialSetupDesc>(value);
		}

		[Ordinal(2)] 
		[RED("tongue")] 
		public animImportFacialSetupDesc Tongue
		{
			get => GetPropertyValue<animImportFacialSetupDesc>();
			set => SetPropertyValue<animImportFacialSetupDesc>(value);
		}

		[Ordinal(3)] 
		[RED("usedTransformIndices")] 
		public CArray<CUInt16> UsedTransformIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(4)] 
		[RED("lipsyncOverrideToMainPosesTracksMapping")] 
		public CArray<CInt16> LipsyncOverrideToMainPosesTracksMapping
		{
			get => GetPropertyValue<CArray<CInt16>>();
			set => SetPropertyValue<CArray<CInt16>>(value);
		}

		[Ordinal(5)] 
		[RED("firstLipsyncOverrideTrackIndex")] 
		public CInt16 FirstLipsyncOverrideTrackIndex
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		public animImportFacialSetupCombinedDesc()
		{
			Face = new() { InitialPose = new(), InitialControls = new() { TransformIds = new(), TransformNames = new(), TransformRegions = new() }, MainPoses = new(), MainPosesInfo = new(), JawAreaTrackIndices = new(), LipsAreaTrackIndices = new(), EyesAreaTrackIndices = new(), CorrectivePoses = new(), GlobalPoseLimits = new(), WrinkleMapping = new() };
			Eyes = new() { InitialPose = new(), InitialControls = new() { TransformIds = new(), TransformNames = new(), TransformRegions = new() }, MainPoses = new(), MainPosesInfo = new(), JawAreaTrackIndices = new(), LipsAreaTrackIndices = new(), EyesAreaTrackIndices = new(), CorrectivePoses = new(), GlobalPoseLimits = new(), WrinkleMapping = new() };
			Tongue = new() { InitialPose = new(), InitialControls = new() { TransformIds = new(), TransformNames = new(), TransformRegions = new() }, MainPoses = new(), MainPosesInfo = new(), JawAreaTrackIndices = new(), LipsAreaTrackIndices = new(), EyesAreaTrackIndices = new(), CorrectivePoses = new(), GlobalPoseLimits = new(), WrinkleMapping = new() };
			UsedTransformIndices = new();
			LipsyncOverrideToMainPosesTracksMapping = new();
			FirstLipsyncOverrideTrackIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
