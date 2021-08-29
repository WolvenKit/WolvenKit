using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayRadio : MusicSettings
	{
		private CEnum<ERadioStationList> _radioStation;

		[Ordinal(1)] 
		[RED("radioStation")] 
		public CEnum<ERadioStationList> RadioStation
		{
			get => GetProperty(ref _radioStation);
			set => SetProperty(ref _radioStation, value);
		}
	}
}
