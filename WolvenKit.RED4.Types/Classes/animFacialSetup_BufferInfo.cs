using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animFacialSetup_BufferInfo : RedBaseClass
	{
		private animFacialSetup_TracksMapping _tracksMapping;
		private CUInt16 _numLipsyncOverridesIndexMapping;
		private CUInt16 _numJointRegions;
		private animFacialSetup_OneSermoBufferInfo _face;
		private animFacialSetup_OneSermoBufferInfo _eyes;
		private animFacialSetup_OneSermoBufferInfo _tongue;

		[Ordinal(0)] 
		[RED("tracksMapping")] 
		public animFacialSetup_TracksMapping TracksMapping
		{
			get => GetProperty(ref _tracksMapping);
			set => SetProperty(ref _tracksMapping, value);
		}

		[Ordinal(1)] 
		[RED("numLipsyncOverridesIndexMapping")] 
		public CUInt16 NumLipsyncOverridesIndexMapping
		{
			get => GetProperty(ref _numLipsyncOverridesIndexMapping);
			set => SetProperty(ref _numLipsyncOverridesIndexMapping, value);
		}

		[Ordinal(2)] 
		[RED("numJointRegions")] 
		public CUInt16 NumJointRegions
		{
			get => GetProperty(ref _numJointRegions);
			set => SetProperty(ref _numJointRegions, value);
		}

		[Ordinal(3)] 
		[RED("face")] 
		public animFacialSetup_OneSermoBufferInfo Face
		{
			get => GetProperty(ref _face);
			set => SetProperty(ref _face, value);
		}

		[Ordinal(4)] 
		[RED("eyes")] 
		public animFacialSetup_OneSermoBufferInfo Eyes
		{
			get => GetProperty(ref _eyes);
			set => SetProperty(ref _eyes, value);
		}

		[Ordinal(5)] 
		[RED("tongue")] 
		public animFacialSetup_OneSermoBufferInfo Tongue
		{
			get => GetProperty(ref _tongue);
			set => SetProperty(ref _tongue, value);
		}
	}
}
