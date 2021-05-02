using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CMaterialGraph : IMaterialDefinition
	{
		[Ordinal(1)] [RED("sortGroup")] 		public CEnum<ERenderingSortGroup> SortGroup { get; set;}

		[Ordinal(2)] [RED("blendMode")] 		public CEnum<ERenderingBlendMode> BlendMode { get; set;}

		[Ordinal(3)] [RED("offset")] 		public Vector Offset { get; set;}

		[Ordinal(4)] [RED("blocks", 2,0)] 		public CArray<CPtr<CGraphBlock>> Blocks { get; set;}

		[Ordinal(5)] [RED("pixelParameterBlocks", 2,0)] 		public CArray<CPtr<CMaterialParameter>> PixelParameterBlocks { get; set;}

		[Ordinal(6)] [RED("vertexParameterBlocks", 2,0)] 		public CArray<CPtr<CMaterialParameter>> VertexParameterBlocks { get; set;}

		[Ordinal(7)] [RED("paramMask")] 		public CUInt32 ParamMask { get; set;}

		[Ordinal(8)] [RED("isTwoSided")] 		public CBool IsTwoSided { get; set;}

		[Ordinal(9)] [RED("isEmissive")] 		public CBool IsEmissive { get; set;}

		[Ordinal(10)] [RED("isMasked")] 		public CBool IsMasked { get; set;}

		[Ordinal(11)] [RED("canOverrideMasked")] 		public CBool CanOverrideMasked { get; set;}

		[Ordinal(12)] [RED("isForward")] 		public CBool IsForward { get; set;}

		[Ordinal(13)] [RED("isAccumulativelyRefracted")] 		public CBool IsAccumulativelyRefracted { get; set;}

		[Ordinal(14)] [RED("isReflectiveMasked")] 		public CBool IsReflectiveMasked { get; set;}

		[Ordinal(15)] [RED("isEye")] 		public CBool IsEye { get; set;}

		[Ordinal(16)] [RED("isMimicMaterial")] 		public CBool IsMimicMaterial { get; set;}

		public CMaterialGraph(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}