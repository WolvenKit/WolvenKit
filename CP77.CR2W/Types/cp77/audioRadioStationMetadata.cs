using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("tracks")] public CArray<CName> Tracks { get; set; }
		[Ordinal(1)]  [RED("speaker")] public CEnum<audioRadioSpeakerType> Speaker { get; set; }

		public audioRadioStationMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
