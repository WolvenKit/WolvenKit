using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CApexDestructionResource : CApexResource
	{
		[Ordinal(0)] [RED("maxDepth")] 		public CUInt32 MaxDepth { get; set;}

		[Ordinal(0)] [RED("originalMaxDepth")] 		public CUInt32 OriginalMaxDepth { get; set;}

		[Ordinal(0)] [RED("supportDepth")] 		public CUInt32 SupportDepth { get; set;}

		[Ordinal(0)] [RED("neighborPadding")] 		public CFloat NeighborPadding { get; set;}

		[Ordinal(0)] [RED("initialAllowance")] 		public CUInt32 InitialAllowance { get; set;}

		[Ordinal(0)] [RED("formExtendedStructures")] 		public CBool FormExtendedStructures { get; set;}

		[Ordinal(0)] [RED("useAssetSupport")] 		public CBool UseAssetSupport { get; set;}

		[Ordinal(0)] [RED("useWorldSupport")] 		public CBool UseWorldSupport { get; set;}

		[Ordinal(0)] [RED("chunkDepthMaterials", 2,0)] 		public CArray<CName> ChunkDepthMaterials { get; set;}

		[Ordinal(0)] [RED("unfracturedDensityScaler")] 		public CFloat UnfracturedDensityScaler { get; set;}

		[Ordinal(0)] [RED("fracturedDensityScaler")] 		public CFloat FracturedDensityScaler { get; set;}

		[Ordinal(0)] [RED("fractureSoundEvent")] 		public StringAnsi FractureSoundEvent { get; set;}

		[Ordinal(0)] [RED("fxName")] 		public CName FxName { get; set;}

		public CApexDestructionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CApexDestructionResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}