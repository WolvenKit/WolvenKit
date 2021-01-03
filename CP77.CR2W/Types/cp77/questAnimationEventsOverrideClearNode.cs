using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questAnimationEventsOverrideClearNode : questIAudioNodeType
	{
		[Ordinal(0)]  [RED("resetActorsOverride")] public CBool ResetActorsOverride { get; set; }
		[Ordinal(1)]  [RED("resetGlobalOverride")] public CBool ResetGlobalOverride { get; set; }

		public questAnimationEventsOverrideClearNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
