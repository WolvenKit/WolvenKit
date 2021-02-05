using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPreviewGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("sceneName")] public CName SceneName { get; set; }
		[Ordinal(1)]  [RED("cameraRef")] public NodeRef CameraRef { get; set; }
		[Ordinal(2)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(3)]  [RED("yawSpeed")] public CFloat YawSpeed { get; set; }
		[Ordinal(4)]  [RED("yawDefault")] public CFloat YawDefault { get; set; }
		[Ordinal(5)]  [RED("isRotatable")] public CBool IsRotatable { get; set; }

		public gameuiPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
