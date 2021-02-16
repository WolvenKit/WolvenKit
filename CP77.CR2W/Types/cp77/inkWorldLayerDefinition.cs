using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkWorldLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] [RED("projectionPlaneSize")] public Vector2 ProjectionPlaneSize { get; set; }
		[Ordinal(9)] [RED("renderingPlane")] public CEnum<ERenderingPlane> RenderingPlane { get; set; }
		[Ordinal(10)] [RED("isInteractableFromBehind")] public CBool IsInteractableFromBehind { get; set; }
		[Ordinal(11)] [RED("maxInteractionDistance")] public CFloat MaxInteractionDistance { get; set; }
		[Ordinal(12)] [RED("useCustomFaceVector")] public CBool UseCustomFaceVector { get; set; }
		[Ordinal(13)] [RED("faceVector")] public Vector3 FaceVector { get; set; }

		public inkWorldLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
