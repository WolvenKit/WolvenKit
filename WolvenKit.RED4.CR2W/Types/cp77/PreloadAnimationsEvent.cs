using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreloadAnimationsEvent : redEvent
	{
		[Ordinal(0)] [RED("streamingContextName")] public CName StreamingContextName { get; set; }
		[Ordinal(1)] [RED("highPriority")] public CBool HighPriority { get; set; }

		public PreloadAnimationsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
