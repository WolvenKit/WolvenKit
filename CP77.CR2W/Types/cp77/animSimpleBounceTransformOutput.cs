using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTransformOutput : CVariable
	{
		[Ordinal(0)]  [RED("channelEntries")] public CArray<animSimpleBounceTransformOutput_ChannelEntry> ChannelEntries { get; set; }
		[Ordinal(1)]  [RED("multiplier")] public CFloat Multiplier { get; set; }
		[Ordinal(2)]  [RED("parentTransform")] public animTransformIndex ParentTransform { get; set; }
		[Ordinal(3)]  [RED("targetTransform")] public animTransformIndex TargetTransform { get; set; }
		[Ordinal(4)]  [RED("targetTransformChannel")] public CEnum<animTransformChannel> TargetTransformChannel { get; set; }

		public animSimpleBounceTransformOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
