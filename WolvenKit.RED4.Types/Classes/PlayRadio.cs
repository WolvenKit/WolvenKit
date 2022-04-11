using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayRadio : MusicSettings
	{
		[Ordinal(1)] 
		[RED("radioStation")] 
		public CEnum<ERadioStationList> RadioStation
		{
			get => GetPropertyValue<CEnum<ERadioStationList>>();
			set => SetPropertyValue<CEnum<ERadioStationList>>(value);
		}
	}
}
