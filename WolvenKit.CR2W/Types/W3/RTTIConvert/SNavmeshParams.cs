using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SNavmeshParams : CVariable
	{
		[RED("useGenerationRootPoints")] 		public CBool UseGenerationRootPoints { get; set;}

		[RED("useTerrainInGeneration")] 		public CBool UseTerrainInGeneration { get; set;}

		[RED("useStaticMeshesInGeneration")] 		public CBool UseStaticMeshesInGeneration { get; set;}

		[RED("collectFoliage")] 		public CBool CollectFoliage { get; set;}

		[RED("previewOriginalGeometry")] 		public CBool PreviewOriginalGeometry { get; set;}

		[RED("useCollisionMeshes")] 		public CBool UseCollisionMeshes { get; set;}

		[RED("monotonePartitioning")] 		public CBool MonotonePartitioning { get; set;}

		[RED("detectTerrainConnection")] 		public CBool DetectTerrainConnection { get; set;}

		[RED("stepOnNonWalkableMeshes")] 		public CBool StepOnNonWalkableMeshes { get; set;}

		[RED("cutMeshesWithBoundings")] 		public CBool CutMeshesWithBoundings { get; set;}

		[RED("smoothWalkableAreas")] 		public CBool SmoothWalkableAreas { get; set;}

		[RED("extensionLength")] 		public CFloat ExtensionLength { get; set;}

		[RED("cellWidth")] 		public CFloat CellWidth { get; set;}

		[RED("cellHeight")] 		public CFloat CellHeight { get; set;}

		[RED("walkableSlopeAngle")] 		public CFloat WalkableSlopeAngle { get; set;}

		[RED("agentHeight")] 		public CFloat AgentHeight { get; set;}

		[RED("agentClimb")] 		public CFloat AgentClimb { get; set;}

		[RED("margin")] 		public CFloat Margin { get; set;}

		[RED("maxEdgeLen")] 		public CFloat MaxEdgeLen { get; set;}

		[RED("maxEdgeError")] 		public CFloat MaxEdgeError { get; set;}

		[RED("regionMinSize")] 		public CFloat RegionMinSize { get; set;}

		[RED("regionMergeSize")] 		public CFloat RegionMergeSize { get; set;}

		[RED("vertsPerPoly")] 		public CUInt32 VertsPerPoly { get; set;}

		[RED("detailSampleDist")] 		public CFloat DetailSampleDist { get; set;}

		[RED("detailSampleMaxError")] 		public CFloat DetailSampleMaxError { get; set;}

		[RED("extraStreamingRange")] 		public CFloat ExtraStreamingRange { get; set;}

		public SNavmeshParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SNavmeshParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}