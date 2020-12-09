using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurVisualizers : CVariable
	{
		[Ordinal(1)] [RED("drawRenderHairs")] 		public CBool DrawRenderHairs { get; set;}

		[Ordinal(2)] [RED("visualizeBones")] 		public CBool VisualizeBones { get; set;}

		[Ordinal(3)] [RED("visualizeCapsules")] 		public CBool VisualizeCapsules { get; set;}

		[Ordinal(4)] [RED("visualizeGuideHairs")] 		public CBool VisualizeGuideHairs { get; set;}

		[Ordinal(5)] [RED("visualizeControlVertices")] 		public CBool VisualizeControlVertices { get; set;}

		[Ordinal(6)] [RED("visualizeBoundingBox")] 		public CBool VisualizeBoundingBox { get; set;}

		[Ordinal(7)] [RED("colorizeMode")] 		public CEnum<EHairColorizeMode> ColorizeMode { get; set;}

		[Ordinal(8)] [RED("visualizeCullSphere")] 		public CBool VisualizeCullSphere { get; set;}

		[Ordinal(9)] [RED("visualizeDiffuseBone")] 		public CBool VisualizeDiffuseBone { get; set;}

		[Ordinal(10)] [RED("visualizeFrames")] 		public CBool VisualizeFrames { get; set;}

		[Ordinal(11)] [RED("visualizeGrowthMesh")] 		public CBool VisualizeGrowthMesh { get; set;}

		[Ordinal(12)] [RED("visualizeHairInteractions")] 		public CBool VisualizeHairInteractions { get; set;}

		[Ordinal(13)] [RED("visualizeHairSkips")] 		public CUInt32 VisualizeHairSkips { get; set;}

		[Ordinal(14)] [RED("visualizeLocalPos")] 		public CBool VisualizeLocalPos { get; set;}

		[Ordinal(15)] [RED("visualizePinConstraints")] 		public CBool VisualizePinConstraints { get; set;}

		[Ordinal(16)] [RED("visualizeShadingNormals")] 		public CBool VisualizeShadingNormals { get; set;}

		[Ordinal(17)] [RED("visualizeSkinnedGuideHairs")] 		public CBool VisualizeSkinnedGuideHairs { get; set;}

		[Ordinal(18)] [RED("visualizeStiffnessBone")] 		public CBool VisualizeStiffnessBone { get; set;}

		public SFurVisualizers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurVisualizers(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}