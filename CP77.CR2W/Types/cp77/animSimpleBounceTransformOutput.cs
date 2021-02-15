using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTransformOutput : CVariable
	{
		[Ordinal(0)] [RED("targetTransform")] public animTransformIndex TargetTransform { get; set; }
		[Ordinal(1)] [RED("parentTransform")] public animTransformIndex ParentTransform { get; set; }
		[Ordinal(2)] [RED("targetTransformChannel")] public CEnum<animTransformChannel> TargetTransformChannel { get; set; }
		[Ordinal(3)] [RED("multiplier")] public CFloat Multiplier { get; set; }
		[Ordinal(4)] [RED("channelEntries")] public CArray<animSimpleBounceTransformOutput_ChannelEntry> ChannelEntries { get; set; }

		public animSimpleBounceTransformOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
