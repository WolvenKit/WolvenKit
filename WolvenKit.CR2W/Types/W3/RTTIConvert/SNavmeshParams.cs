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
		[Ordinal(1)] [RED("("useGenerationRootPoints")] 		public CBool UseGenerationRootPoints { get; set;}

		[Ordinal(2)] [RED("("useTerrainInGeneration")] 		public CBool UseTerrainInGeneration { get; set;}

		[Ordinal(3)] [RED("("useStaticMeshesInGeneration")] 		public CBool UseStaticMeshesInGeneration { get; set;}

		[Ordinal(4)] [RED("("collectFoliage")] 		public CBool CollectFoliage { get; set;}

		[Ordinal(5)] [RED("("previewOriginalGeometry")] 		public CBool PreviewOriginalGeometry { get; set;}

		[Ordinal(6)] [RED("("useCollisionMeshes")] 		public CBool UseCollisionMeshes { get; set;}

		[Ordinal(7)] [RED("("monotonePartitioning")] 		public CBool MonotonePartitioning { get; set;}

		[Ordinal(8)] [RED("("detectTerrainConnection")] 		public CBool DetectTerrainConnection { get; set;}

		[Ordinal(9)] [RED("("stepOnNonWalkableMeshes")] 		public CBool StepOnNonWalkableMeshes { get; set;}

		[Ordinal(10)] [RED("("cutMeshesWithBoundings")] 		public CBool CutMeshesWithBoundings { get; set;}

		[Ordinal(11)] [RED("("smoothWalkableAreas")] 		public CBool SmoothWalkableAreas { get; set;}

		[Ordinal(12)] [RED("("extensionLength")] 		public CFloat ExtensionLength { get; set;}

		[Ordinal(13)] [RED("("cellWidth")] 		public CFloat CellWidth { get; set;}

		[Ordinal(14)] [RED("("cellHeight")] 		public CFloat CellHeight { get; set;}

		[Ordinal(15)] [RED("("walkableSlopeAngle")] 		public CFloat WalkableSlopeAngle { get; set;}

		[Ordinal(16)] [RED("("agentHeight")] 		public CFloat AgentHeight { get; set;}

		[Ordinal(17)] [RED("("agentClimb")] 		public CFloat AgentClimb { get; set;}

		[Ordinal(18)] [RED("("margin")] 		public CFloat Margin { get; set;}

		[Ordinal(19)] [RED("("maxEdgeLen")] 		public CFloat MaxEdgeLen { get; set;}

		[Ordinal(20)] [RED("("maxEdgeError")] 		public CFloat MaxEdgeError { get; set;}

		[Ordinal(21)] [RED("("regionMinSize")] 		public CFloat RegionMinSize { get; set;}

		[Ordinal(22)] [RED("("regionMergeSize")] 		public CFloat RegionMergeSize { get; set;}

		[Ordinal(23)] [RED("("vertsPerPoly")] 		public CUInt32 VertsPerPoly { get; set;}

		[Ordinal(24)] [RED("("detailSampleDist")] 		public CFloat DetailSampleDist { get; set;}

		[Ordinal(25)] [RED("("detailSampleMaxError")] 		public CFloat DetailSampleMaxError { get; set;}

		[Ordinal(26)] [RED("("extraStreamingRange")] 		public CFloat ExtraStreamingRange { get; set;}

		public SNavmeshParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SNavmeshParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}