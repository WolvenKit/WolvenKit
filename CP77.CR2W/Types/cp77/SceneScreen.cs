using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SceneScreen : gameObject
	{
		[Ordinal(0)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(1)]  [RED("uiAnimationsData")] public CHandle<SceneScreenUIAnimationsData> UiAnimationsData { get; set; }

		public SceneScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
