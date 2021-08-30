using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animImportFacialSetupCombinedDesc : RedBaseClass
	{
		private animImportFacialSetupDesc _face;
		private animImportFacialSetupDesc _eyes;
		private animImportFacialSetupDesc _tongue;
		private CArray<CUInt16> _usedTransformIndices;
		private CArray<CInt16> _lipsyncOverrideToMainPosesTracksMapping;
		private CInt16 _firstLipsyncOverrideTrackIndex;

		[Ordinal(0)] 
		[RED("face")] 
		public animImportFacialSetupDesc Face
		{
			get => GetProperty(ref _face);
			set => SetProperty(ref _face, value);
		}

		[Ordinal(1)] 
		[RED("eyes")] 
		public animImportFacialSetupDesc Eyes
		{
			get => GetProperty(ref _eyes);
			set => SetProperty(ref _eyes, value);
		}

		[Ordinal(2)] 
		[RED("tongue")] 
		public animImportFacialSetupDesc Tongue
		{
			get => GetProperty(ref _tongue);
			set => SetProperty(ref _tongue, value);
		}

		[Ordinal(3)] 
		[RED("usedTransformIndices")] 
		public CArray<CUInt16> UsedTransformIndices
		{
			get => GetProperty(ref _usedTransformIndices);
			set => SetProperty(ref _usedTransformIndices, value);
		}

		[Ordinal(4)] 
		[RED("lipsyncOverrideToMainPosesTracksMapping")] 
		public CArray<CInt16> LipsyncOverrideToMainPosesTracksMapping
		{
			get => GetProperty(ref _lipsyncOverrideToMainPosesTracksMapping);
			set => SetProperty(ref _lipsyncOverrideToMainPosesTracksMapping, value);
		}

		[Ordinal(5)] 
		[RED("firstLipsyncOverrideTrackIndex")] 
		public CInt16 FirstLipsyncOverrideTrackIndex
		{
			get => GetProperty(ref _firstLipsyncOverrideTrackIndex);
			set => SetProperty(ref _firstLipsyncOverrideTrackIndex, value);
		}

		public animImportFacialSetupCombinedDesc()
		{
			_firstLipsyncOverrideTrackIndex = -1;
		}
	}
}
