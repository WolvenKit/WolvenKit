using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EventValue : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(1)]  [RED("eventName")] public CName EventName { get; set; }

		public animAnimNode_EventValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
