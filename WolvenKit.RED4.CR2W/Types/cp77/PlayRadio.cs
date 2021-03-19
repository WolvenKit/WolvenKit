using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayRadio : MusicSettings
	{
		private CEnum<ERadioStationList> _radioStation;

		[Ordinal(1)] 
		[RED("radioStation")] 
		public CEnum<ERadioStationList> RadioStation
		{
			get => GetProperty(ref _radioStation);
			set => SetProperty(ref _radioStation, value);
		}

		public PlayRadio(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
