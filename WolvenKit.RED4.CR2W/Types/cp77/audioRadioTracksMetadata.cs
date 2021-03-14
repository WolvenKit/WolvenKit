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
			get
			{
				if (_radioTracks == null)
				{
					_radioTracks = (CArray<audioRadioTrack>) CR2WTypeManager.Create("array:audioRadioTrack", "radioTracks", cr2w, this);
				}
				return _radioTracks;
			}
			set
			{
				if (_radioTracks == value)
				{
					return;
				}
				_radioTracks = value;
				PropertySet(this);
			}
		}

		public audioRadioTracksMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
