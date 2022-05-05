using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNodeSourceChannel_WeightedQuat : ISerializable
	{
		[Ordinal(0)] 
		[RED("channel")] 
		public CHandle<animIAnimNodeSourceChannel_Quat> Channel
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_Quat>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_Quat>>(value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(3)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNodeSourceChannel_WeightedQuat()
		{
			Weight = 1.000000F;
			WeightLink = new();
			WeightFloatTrack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
