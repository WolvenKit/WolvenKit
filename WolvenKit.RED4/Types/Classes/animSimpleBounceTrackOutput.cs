using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSimpleBounceTrackOutput : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetTrack")] 
		public animNamedTrackIndex TargetTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animSimpleBounceTrackOutput()
		{
			TargetTrack = new();
			Multiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
