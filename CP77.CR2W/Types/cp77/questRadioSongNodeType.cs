using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRadioSongNodeType : questIAudioNodeType
	{
		[Ordinal(0)]  [RED("radioStationEvents")] public CArray<audioRadioStationSongEventStruct> RadioStationEvents { get; set; }

		public questRadioSongNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
