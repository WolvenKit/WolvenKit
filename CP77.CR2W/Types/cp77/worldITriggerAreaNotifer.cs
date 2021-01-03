using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldITriggerAreaNotifer : IScriptable
	{
		[Ordinal(0)]  [RED("excludeChannels")] public CUInt32 ExcludeChannels { get; set; }
		[Ordinal(1)]  [RED("includeChannels")] public CEnum<TriggerChannel> IncludeChannels { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public worldITriggerAreaNotifer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
