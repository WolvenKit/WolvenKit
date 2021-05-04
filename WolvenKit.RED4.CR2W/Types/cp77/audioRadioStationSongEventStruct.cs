using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationSongEventStruct : CVariable
	{
		private CName _radioStationName;
		private CName _radioSongName;

		[Ordinal(0)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get => GetProperty(ref _radioStationName);
			set => SetProperty(ref _radioStationName, value);
		}

		[Ordinal(1)] 
		[RED("radioSongName")] 
		public CName RadioSongName
		{
			get => GetProperty(ref _radioSongName);
			set => SetProperty(ref _radioSongName, value);
		}

		public audioRadioStationSongEventStruct(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
