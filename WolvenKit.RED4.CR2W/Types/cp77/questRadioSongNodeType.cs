using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRadioSongNodeType : questIAudioNodeType
	{
		[Ordinal(0)] [RED("radioStationEvents")] public CArray<audioRadioStationSongEventStruct> RadioStationEvents { get; set; }

		public questRadioSongNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
