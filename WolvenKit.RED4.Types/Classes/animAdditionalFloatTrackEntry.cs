using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAdditionalFloatTrackEntry : ISerializable
	{
		private CName _name;
		private animFloatTrackInfo _trackInfo;
		private CLegacySingleChannelCurve<CFloat> _values;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("trackInfo")] 
		public animFloatTrackInfo TrackInfo
		{
			get => GetProperty(ref _trackInfo);
			set => SetProperty(ref _trackInfo, value);
		}

		[Ordinal(2)] 
		[RED("values")] 
		public CLegacySingleChannelCurve<CFloat> Values
		{
			get => GetProperty(ref _values);
			set => SetProperty(ref _values, value);
		}
	}
}
