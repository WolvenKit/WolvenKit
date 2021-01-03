using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WorkspotAnim : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("collectEvents")] public CBool CollectEvents { get; set; }
		[Ordinal(1)]  [RED("inputLink")] public animPoseLink InputLink { get; set; }

		public animAnimNode_WorkspotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
