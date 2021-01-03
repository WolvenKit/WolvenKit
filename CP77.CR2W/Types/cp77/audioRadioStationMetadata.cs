using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("speaker")] public CEnum<audioRadioSpeakerType> Speaker { get; set; }
		[Ordinal(1)]  [RED("tracks")] public CArray<CName> Tracks { get; set; }

		public audioRadioStationMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
