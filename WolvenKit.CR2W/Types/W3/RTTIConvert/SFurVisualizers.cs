using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurVisualizers : CVariable
	{
		[RED("drawRenderHairs")] 		public CBool DrawRenderHairs { get; set;}

		[RED("visualizeBones")] 		public CBool VisualizeBones { get; set;}

		[RED("visualizeCapsules")] 		public CBool VisualizeCapsules { get; set;}

		[RED("visualizeGuideHairs")] 		public CBool VisualizeGuideHairs { get; set;}

		[RED("visualizeControlVertices")] 		public CBool VisualizeControlVertices { get; set;}

		[RED("visualizeBoundingBox")] 		public CBool VisualizeBoundingBox { get; set;}

		[RED("colorizeMode")] 		public CEnum<EHairColorizeMode> ColorizeMode { get; set;}

		[RED("visualizeCullSphere")] 		public CBool VisualizeCullSphere { get; set;}

		[RED("visualizeDiffuseBone")] 		public CBool VisualizeDiffuseBone { get; set;}

		[RED("visualizeFrames")] 		public CBool VisualizeFrames { get; set;}

		[RED("visualizeGrowthMesh")] 		public CBool VisualizeGrowthMesh { get; set;}

		[RED("visualizeHairInteractions")] 		public CBool VisualizeHairInteractions { get; set;}

		[RED("visualizeHairSkips")] 		public CUInt32 VisualizeHairSkips { get; set;}

		[RED("visualizeLocalPos")] 		public CBool VisualizeLocalPos { get; set;}

		[RED("visualizePinConstraints")] 		public CBool VisualizePinConstraints { get; set;}

		[RED("visualizeShadingNormals")] 		public CBool VisualizeShadingNormals { get; set;}

		[RED("visualizeSkinnedGuideHairs")] 		public CBool VisualizeSkinnedGuideHairs { get; set;}

		[RED("visualizeStiffnessBone")] 		public CBool VisualizeStiffnessBone { get; set;}

		public SFurVisualizers(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFurVisualizers(cr2w);

	}
}