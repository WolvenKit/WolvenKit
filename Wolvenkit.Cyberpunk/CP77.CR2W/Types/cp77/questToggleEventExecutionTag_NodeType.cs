using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questToggleEventExecutionTag_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)]  [RED("eventExecutionTag")] public CName EventExecutionTag { get; set; }
		[Ordinal(1)]  [RED("mute")] public CBool Mute { get; set; }
		[Ordinal(2)]  [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }

		public questToggleEventExecutionTag_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
