using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("tracks")] public CArray<CName> Tracks { get; set; }
		[Ordinal(2)] [RED("speaker")] public CEnum<audioRadioSpeakerType> Speaker { get; set; }

		public audioRadioStationMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
