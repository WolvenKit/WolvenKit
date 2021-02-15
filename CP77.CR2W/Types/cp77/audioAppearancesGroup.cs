using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAppearancesGroup : audioAudioMetadata
	{
		[Ordinal(1)] [RED("appearances")] public CArray<CName> Appearances { get; set; }

		public audioAppearancesGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
