using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioSourceBasedReverbBussesMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("exterior")] public CName Exterior { get; set; }
		[Ordinal(1)]  [RED("interiorLarge")] public CName InteriorLarge { get; set; }
		[Ordinal(2)]  [RED("interiorMedium")] public CName InteriorMedium { get; set; }
		[Ordinal(3)]  [RED("interiorSmall")] public CName InteriorSmall { get; set; }

		public audioSourceBasedReverbBussesMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
