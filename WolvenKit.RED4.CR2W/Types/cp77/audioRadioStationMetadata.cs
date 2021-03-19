using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationMetadata : audioAudioMetadata
	{
		private CArray<CName> _tracks;
		private CEnum<audioRadioSpeakerType> _speaker;

		[Ordinal(1)] 
		[RED("tracks")] 
		public CArray<CName> Tracks
		{
			get => GetProperty(ref _tracks);
			set => SetProperty(ref _tracks, value);
		}

		[Ordinal(2)] 
		[RED("speaker")] 
		public CEnum<audioRadioSpeakerType> Speaker
		{
			get => GetProperty(ref _speaker);
			set => SetProperty(ref _speaker, value);
		}

		public audioRadioStationMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
