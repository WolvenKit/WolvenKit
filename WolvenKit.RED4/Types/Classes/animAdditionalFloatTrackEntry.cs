using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAdditionalFloatTrackEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("trackInfo")] 
		public animFloatTrackInfo TrackInfo
		{
			get => GetPropertyValue<animFloatTrackInfo>();
			set => SetPropertyValue<animFloatTrackInfo>(value);
		}

		[Ordinal(2)] 
		[RED("values")] 
		public CLegacySingleChannelCurve<CFloat> Values
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public animAdditionalFloatTrackEntry()
		{
			TrackInfo = new animFloatTrackInfo();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
