using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CMaterialGraph : IMaterialDefinition
	{
		[Ordinal(0)] [RED("sortGroup")] 		public CEnum<ERenderingSortGroup> SortGroup { get; set;}

		[Ordinal(0)] [RED("blendMode")] 		public CEnum<ERenderingBlendMode> BlendMode { get; set;}

		[Ordinal(0)] [RED("offset")] 		public Vector Offset { get; set;}

		[Ordinal(0)] [RED("blocks", 2,0)] 		public CArray<CPtr<CGraphBlock>> Blocks { get; set;}

		[Ordinal(0)] [RED("pixelParameterBlocks", 2,0)] 		public CArray<CPtr<CMaterialParameter>> PixelParameterBlocks { get; set;}

		[Ordinal(0)] [RED("vertexParameterBlocks", 2,0)] 		public CArray<CPtr<CMaterialParameter>> VertexParameterBlocks { get; set;}

		[Ordinal(0)] [RED("paramMask")] 		public CUInt32 ParamMask { get; set;}

		[Ordinal(0)] [RED("isTwoSided")] 		public CBool IsTwoSided { get; set;}

		[Ordinal(0)] [RED("isEmissive")] 		public CBool IsEmissive { get; set;}

		[Ordinal(0)] [RED("isMasked")] 		public CBool IsMasked { get; set;}

		[Ordinal(0)] [RED("canOverrideMasked")] 		public CBool CanOverrideMasked { get; set;}

		[Ordinal(0)] [RED("isForward")] 		public CBool IsForward { get; set;}

		[Ordinal(0)] [RED("isAccumulativelyRefracted")] 		public CBool IsAccumulativelyRefracted { get; set;}

		[Ordinal(0)] [RED("isReflectiveMasked")] 		public CBool IsReflectiveMasked { get; set;}

		[Ordinal(0)] [RED("isEye")] 		public CBool IsEye { get; set;}

		[Ordinal(0)] [RED("isMimicMaterial")] 		public CBool IsMimicMaterial { get; set;}

		public CMaterialGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialGraph(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}