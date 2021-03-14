using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTransformOutput_ChannelEntry : CVariable
	{
		[Ordinal(0)] [RED("transformChannel")] public CEnum<animTransformChannel> TransformChannel { get; set; }
		[Ordinal(1)] [RED("multiplier")] public CFloat Multiplier { get; set; }

		public animSimpleBounceTransformOutput_ChannelEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
