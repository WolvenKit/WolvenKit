using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioTracksMetadata : audioAudioMetadata
	{
		private CArray<audioRadioTrack> _radioTracks;

		[Ordinal(1)] 
		[RED("radioTracks")] 
		public CArray<audioRadioTrack> RadioTracks
		{
			get => GetProperty(ref _radioTracks);
			set => SetProperty(ref _radioTracks, value);
		}

		public audioRadioTracksMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
