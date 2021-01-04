using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTransformOutput_ChannelEntry : CVariable
	{
		[Ordinal(0)]  [RED("multiplier")] public CFloat Multiplier { get; set; }
		[Ordinal(1)]  [RED("transformChannel")] public CEnum<animTransformChannel> TransformChannel { get; set; }

		public animSimpleBounceTransformOutput_ChannelEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
