using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animOverrideBlendTrackInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animOverrideBlendTrackInfo()
		{
			Track = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
