using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurVisualizers : CVariable
	{
		[Ordinal(0)] [RED("("drawRenderHairs")] 		public CBool DrawRenderHairs { get; set;}

		[Ordinal(0)] [RED("("visualizeBones")] 		public CBool VisualizeBones { get; set;}

		[Ordinal(0)] [RED("("visualizeCapsules")] 		public CBool VisualizeCapsules { get; set;}

		[Ordinal(0)] [RED("("visualizeGuideHairs")] 		public CBool VisualizeGuideHairs { get; set;}

		[Ordinal(0)] [RED("("visualizeControlVertices")] 		public CBool VisualizeControlVertices { get; set;}

		[Ordinal(0)] [RED("("visualizeBoundingBox")] 		public CBool VisualizeBoundingBox { get; set;}

		[Ordinal(0)] [RED("("colorizeMode")] 		public CEnum<EHairColorizeMode> ColorizeMode { get; set;}

		[Ordinal(0)] [RED("("visualizeCullSphere")] 		public CBool VisualizeCullSphere { get; set;}

		[Ordinal(0)] [RED("("visualizeDiffuseBone")] 		public CBool VisualizeDiffuseBone { get; set;}

		[Ordinal(0)] [RED("("visualizeFrames")] 		public CBool VisualizeFrames { get; set;}

		[Ordinal(0)] [RED("("visualizeGrowthMesh")] 		public CBool VisualizeGrowthMesh { get; set;}

		[Ordinal(0)] [RED("("visualizeHairInteractions")] 		public CBool VisualizeHairInteractions { get; set;}

		[Ordinal(0)] [RED("("visualizeHairSkips")] 		public CUInt32 VisualizeHairSkips { get; set;}

		[Ordinal(0)] [RED("("visualizeLocalPos")] 		public CBool VisualizeLocalPos { get; set;}

		[Ordinal(0)] [RED("("visualizePinConstraints")] 		public CBool VisualizePinConstraints { get; set;}

		[Ordinal(0)] [RED("("visualizeShadingNormals")] 		public CBool VisualizeShadingNormals { get; set;}

		[Ordinal(0)] [RED("("visualizeSkinnedGuideHairs")] 		public CBool VisualizeSkinnedGuideHairs { get; set;}

		[Ordinal(0)] [RED("("visualizeStiffnessBone")] 		public CBool VisualizeStiffnessBone { get; set;}

		public SFurVisualizers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurVisualizers(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}