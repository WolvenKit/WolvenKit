using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSimpleBounceTrackOutput : RedBaseClass
	{
		private animNamedTrackIndex _targetTrack;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("targetTrack")] 
		public animNamedTrackIndex TargetTrack
		{
			get => GetProperty(ref _targetTrack);
			set => SetProperty(ref _targetTrack, value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}

		public animSimpleBounceTrackOutput()
		{
			_multiplier = 1.000000F;
		}
	}
}
