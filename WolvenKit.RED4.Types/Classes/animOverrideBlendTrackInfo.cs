using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animOverrideBlendTrackInfo : RedBaseClass
	{
		private animNamedTrackIndex _track;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get => GetProperty(ref _track);
			set => SetProperty(ref _track, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}
	}
}
