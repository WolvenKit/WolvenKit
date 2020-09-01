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
		[Ordinal(0)] [RED("("useGenerationRootPoints")] 		public CBool UseGenerationRootPoints { get; set;}

		[Ordinal(0)] [RED("("useTerrainInGeneration")] 		public CBool UseTerrainInGeneration { get; set;}

		[Ordinal(0)] [RED("("useStaticMeshesInGeneration")] 		public CBool UseStaticMeshesInGeneration { get; set;}

		[Ordinal(0)] [RED("("collectFoliage")] 		public CBool CollectFoliage { get; set;}

		[Ordinal(0)] [RED("("previewOriginalGeometry")] 		public CBool PreviewOriginalGeometry { get; set;}

		[Ordinal(0)] [RED("("useCollisionMeshes")] 		public CBool UseCollisionMeshes { get; set;}

		[Ordinal(0)] [RED("("monotonePartitioning")] 		public CBool MonotonePartitioning { get; set;}

		[Ordinal(0)] [RED("("detectTerrainConnection")] 		public CBool DetectTerrainConnection { get; set;}

		[Ordinal(0)] [RED("("stepOnNonWalkableMeshes")] 		public CBool StepOnNonWalkableMeshes { get; set;}

		[Ordinal(0)] [RED("("cutMeshesWithBoundings")] 		public CBool CutMeshesWithBoundings { get; set;}

		[Ordinal(0)] [RED("("smoothWalkableAreas")] 		public CBool SmoothWalkableAreas { get; set;}

		[Ordinal(0)] [RED("("extensionLength")] 		public CFloat ExtensionLength { get; set;}

		[Ordinal(0)] [RED("("cellWidth")] 		public CFloat CellWidth { get; set;}

		[Ordinal(0)] [RED("("cellHeight")] 		public CFloat CellHeight { get; set;}

		[Ordinal(0)] [RED("("walkableSlopeAngle")] 		public CFloat WalkableSlopeAngle { get; set;}

		[Ordinal(0)] [RED("("agentHeight")] 		public CFloat AgentHeight { get; set;}

		[Ordinal(0)] [RED("("agentClimb")] 		public CFloat AgentClimb { get; set;}

		[Ordinal(0)] [RED("("margin")] 		public CFloat Margin { get; set;}

		[Ordinal(0)] [RED("("maxEdgeLen")] 		public CFloat MaxEdgeLen { get; set;}

		[Ordinal(0)] [RED("("maxEdgeError")] 		public CFloat MaxEdgeError { get; set;}

		[Ordinal(0)] [RED("("regionMinSize")] 		public CFloat RegionMinSize { get; set;}

		[Ordinal(0)] [RED("("regionMergeSize")] 		public CFloat RegionMergeSize { get; set;}

		[Ordinal(0)] [RED("("vertsPerPoly")] 		public CUInt32 VertsPerPoly { get; set;}

		[Ordinal(0)] [RED("("detailSampleDist")] 		public CFloat DetailSampleDist { get; set;}

		[Ordinal(0)] [RED("("detailSampleMaxError")] 		public CFloat DetailSampleMaxError { get; set;}

		[Ordinal(0)] [RED("("extraStreamingRange")] 		public CFloat ExtraStreamingRange { get; set;}

		public SNavmeshParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SNavmeshParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}