using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleRadioStationChanged : redEvent
	{
		[Ordinal(0)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(1)]  [RED("radioIndex")] public CUInt32 RadioIndex { get; set; }
		[Ordinal(2)]  [RED("radioSongName")] public CName RadioSongName { get; set; }
		[Ordinal(3)]  [RED("radioStationName")] public CName RadioStationName { get; set; }

		public vehicleRadioStationChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
