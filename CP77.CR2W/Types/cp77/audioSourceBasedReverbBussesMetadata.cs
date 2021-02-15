using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioSourceBasedReverbBussesMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("exterior")] public CName Exterior { get; set; }
		[Ordinal(2)] [RED("interiorLarge")] public CName InteriorLarge { get; set; }
		[Ordinal(3)] [RED("interiorMedium")] public CName InteriorMedium { get; set; }
		[Ordinal(4)] [RED("interiorSmall")] public CName InteriorSmall { get; set; }

		public audioSourceBasedReverbBussesMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
