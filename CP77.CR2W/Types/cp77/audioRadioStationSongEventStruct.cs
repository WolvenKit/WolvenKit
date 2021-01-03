using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationSongEventStruct : CVariable
	{
		[Ordinal(0)]  [RED("radioSongName")] public CName RadioSongName { get; set; }
		[Ordinal(1)]  [RED("radioStationName")] public CName RadioStationName { get; set; }

		public audioRadioStationSongEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
