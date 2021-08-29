using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleRadioSongChanged : redEvent
	{
		private CName _radioSongName;

		[Ordinal(0)] 
		[RED("radioSongName")] 
		public CName RadioSongName
		{
			get => GetProperty(ref _radioSongName);
			set => SetProperty(ref _radioSongName, value);
		}
	}
}
