using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraPlacementEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("cameraRef")] public NodeRef CameraRef { get; set; }
		[Ordinal(1)]  [RED("cameraTransformLS")] public Transform CameraTransformLS { get; set; }

		public scneventsCameraPlacementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
