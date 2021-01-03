using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkWorldLayerDefinition : inkLayerDefinition
	{
		[Ordinal(0)]  [RED("faceVector")] public Vector3 FaceVector { get; set; }
		[Ordinal(1)]  [RED("isInteractableFromBehind")] public CBool IsInteractableFromBehind { get; set; }
		[Ordinal(2)]  [RED("maxInteractionDistance")] public CFloat MaxInteractionDistance { get; set; }
		[Ordinal(3)]  [RED("projectionPlaneSize")] public Vector2 ProjectionPlaneSize { get; set; }
		[Ordinal(4)]  [RED("renderingPlane")] public CEnum<ERenderingPlane> RenderingPlane { get; set; }
		[Ordinal(5)]  [RED("useCustomFaceVector")] public CBool UseCustomFaceVector { get; set; }

		public inkWorldLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
