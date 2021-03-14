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
			get
			{
				if (_tracks == null)
				{
					_tracks = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tracks", cr2w, this);
				}
				return _tracks;
			}
			set
			{
				if (_tracks == value)
				{
					return;
				}
				_tracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speaker")] 
		public CEnum<audioRadioSpeakerType> Speaker
		{
			get
			{
				if (_speaker == null)
				{
					_speaker = (CEnum<audioRadioSpeakerType>) CR2WTypeManager.Create("audioRadioSpeakerType", "speaker", cr2w, this);
				}
				return _speaker;
			}
			set
			{
				if (_speaker == value)
				{
					return;
				}
				_speaker = value;
				PropertySet(this);
			}
		}

		public audioRadioStationMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
