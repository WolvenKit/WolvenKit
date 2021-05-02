using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CApexDestructionResource : CApexResource
	{
		[Ordinal(1)] [RED("maxDepth")] 		public CUInt32 MaxDepth { get; set;}

		[Ordinal(2)] [RED("originalMaxDepth")] 		public CUInt32 OriginalMaxDepth { get; set;}

		[Ordinal(3)] [RED("supportDepth")] 		public CUInt32 SupportDepth { get; set;}

		[Ordinal(4)] [RED("neighborPadding")] 		public CFloat NeighborPadding { get; set;}

		[Ordinal(5)] [RED("initialAllowance")] 		public CUInt32 InitialAllowance { get; set;}

		[Ordinal(6)] [RED("formExtendedStructures")] 		public CBool FormExtendedStructures { get; set;}

		[Ordinal(7)] [RED("useAssetSupport")] 		public CBool UseAssetSupport { get; set;}

		[Ordinal(8)] [RED("useWorldSupport")] 		public CBool UseWorldSupport { get; set;}

		[Ordinal(9)] [RED("chunkDepthMaterials", 2,0)] 		public CArray<CName> ChunkDepthMaterials { get; set;}

		[Ordinal(10)] [RED("unfracturedDensityScaler")] 		public CFloat UnfracturedDensityScaler { get; set;}

		[Ordinal(11)] [RED("fracturedDensityScaler")] 		public CFloat FracturedDensityScaler { get; set;}

		[Ordinal(12)] [RED("fractureSoundEvent")] 		public StringAnsi FractureSoundEvent { get; set;}

		[Ordinal(13)] [RED("fxName")] 		public CName FxName { get; set;}

		public CApexDestructionResource(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}