using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioFootstepsMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("defaultFootwearMetadata")] public CName DefaultFootwearMetadata { get; set; }
		[Ordinal(1)]  [RED("footwearMetadataArray")] public CArray<CName> FootwearMetadataArray { get; set; }
		[Ordinal(2)]  [RED("onEnterSound")] public CName OnEnterSound { get; set; }
		[Ordinal(3)]  [RED("onExitSound")] public CName OnExitSound { get; set; }
		[Ordinal(4)]  [RED("slideEvent")] public CName SlideEvent { get; set; }

		public audioFootstepsMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
