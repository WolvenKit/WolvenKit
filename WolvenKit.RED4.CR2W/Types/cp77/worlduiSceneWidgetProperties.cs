using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worlduiSceneWidgetProperties : CVariable
	{
		[Ordinal(0)] [RED("projectionPlaneSize")] public Vector2 ProjectionPlaneSize { get; set; }
		[Ordinal(1)] [RED("renderingPlane")] public CEnum<ERenderingPlane> RenderingPlane { get; set; }
		[Ordinal(2)] [RED("isInteractable")] public CBool IsInteractable { get; set; }
		[Ordinal(3)] [RED("isInteractableFromBehind")] public CBool IsInteractableFromBehind { get; set; }
		[Ordinal(4)] [RED("maxInteractionDistance")] public CFloat MaxInteractionDistance { get; set; }
		[Ordinal(5)] [RED("useCustomFaceVector")] public CBool UseCustomFaceVector { get; set; }
		[Ordinal(6)] [RED("faceVector")] public Vector3 FaceVector { get; set; }

		public worlduiSceneWidgetProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
