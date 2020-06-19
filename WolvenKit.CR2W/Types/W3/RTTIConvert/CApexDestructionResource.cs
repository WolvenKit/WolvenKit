using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CApexDestructionResource : CApexResource
	{
		[RED("maxDepth")] 		public CUInt32 MaxDepth { get; set;}

		[RED("originalMaxDepth")] 		public CUInt32 OriginalMaxDepth { get; set;}

		[RED("supportDepth")] 		public CUInt32 SupportDepth { get; set;}

		[RED("neighborPadding")] 		public CFloat NeighborPadding { get; set;}

		[RED("initialAllowance")] 		public CUInt32 InitialAllowance { get; set;}

		[RED("formExtendedStructures")] 		public CBool FormExtendedStructures { get; set;}

		[RED("useAssetSupport")] 		public CBool UseAssetSupport { get; set;}

		[RED("useWorldSupport")] 		public CBool UseWorldSupport { get; set;}

		[RED("chunkDepthMaterials", 2,0)] 		public CArray<CName> ChunkDepthMaterials { get; set;}

		[RED("unfracturedDensityScaler")] 		public CFloat UnfracturedDensityScaler { get; set;}

		[RED("fracturedDensityScaler")] 		public CFloat FracturedDensityScaler { get; set;}

		[RED("fractureSoundEvent")] 		public StringAnsi FractureSoundEvent { get; set;}

		[RED("fxName")] 		public CName FxName { get; set;}

		public CApexDestructionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CApexDestructionResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}