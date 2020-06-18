using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CMaterialGraph : IMaterialDefinition
	{
		[RED("sortGroup")] 		public CEnum<ERenderingSortGroup> SortGroup { get; set;}

		[RED("blendMode")] 		public CEnum<ERenderingBlendMode> BlendMode { get; set;}

		[RED("offset")] 		public Vector Offset { get; set;}

		[RED("blocks", 2,0)] 		public CArray<CPtr<CGraphBlock>> Blocks { get; set;}

		[RED("pixelParameterBlocks", 2,0)] 		public CArray<CPtr<CMaterialParameter>> PixelParameterBlocks { get; set;}

		[RED("vertexParameterBlocks", 2,0)] 		public CArray<CPtr<CMaterialParameter>> VertexParameterBlocks { get; set;}

		[RED("paramMask")] 		public CUInt32 ParamMask { get; set;}

		[RED("isTwoSided")] 		public CBool IsTwoSided { get; set;}

		[RED("isEmissive")] 		public CBool IsEmissive { get; set;}

		[RED("isMasked")] 		public CBool IsMasked { get; set;}

		[RED("canOverrideMasked")] 		public CBool CanOverrideMasked { get; set;}

		[RED("isForward")] 		public CBool IsForward { get; set;}

		[RED("isAccumulativelyRefracted")] 		public CBool IsAccumulativelyRefracted { get; set;}

		[RED("isReflectiveMasked")] 		public CBool IsReflectiveMasked { get; set;}

		[RED("isEye")] 		public CBool IsEye { get; set;}

		[RED("isMimicMaterial")] 		public CBool IsMimicMaterial { get; set;}

		public CMaterialGraph(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new CMaterialGraph(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}