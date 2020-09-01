using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphHorseNode : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("("cachedSpeedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedValueNode { get; set;}

		[Ordinal(0)] [RED("("speedStep")] 		public CFloat SpeedStep { get; set;}

		[Ordinal(0)] [RED("("slopeFBVar")] 		public CName SlopeFBVar { get; set;}

		[Ordinal(0)] [RED("("slopeLRVar")] 		public CName SlopeLRVar { get; set;}

		[Ordinal(0)] [RED("("firstBoneF")] 		public CString FirstBoneF { get; set;}

		[Ordinal(0)] [RED("("secondBoneF")] 		public CString SecondBoneF { get; set;}

		[Ordinal(0)] [RED("("thirdBoneF")] 		public CString ThirdBoneF { get; set;}

		[Ordinal(0)] [RED("("endBoneF")] 		public CString EndBoneF { get; set;}

		[Ordinal(0)] [RED("("hingeAxisF")] 		public CEnum<EAxis> HingeAxisF { get; set;}

		[Ordinal(0)] [RED("("firstBoneB")] 		public CString FirstBoneB { get; set;}

		[Ordinal(0)] [RED("("secondBoneB")] 		public CString SecondBoneB { get; set;}

		[Ordinal(0)] [RED("("thirdBoneB")] 		public CString ThirdBoneB { get; set;}

		[Ordinal(0)] [RED("("endBoneB")] 		public CString EndBoneB { get; set;}

		[Ordinal(0)] [RED("("hingeAxisB")] 		public CEnum<EAxis> HingeAxisB { get; set;}

		[Ordinal(0)] [RED("("root")] 		public CString Root { get; set;}

		[Ordinal(0)] [RED("("pelvis")] 		public CString Pelvis { get; set;}

		[Ordinal(0)] [RED("("axisRootFB")] 		public CEnum<EAxis> AxisRootFB { get; set;}

		[Ordinal(0)] [RED("("axisRootLR")] 		public CEnum<EAxis> AxisRootLR { get; set;}

		[Ordinal(0)] [RED("("headFirst")] 		public CString HeadFirst { get; set;}

		[Ordinal(0)] [RED("("headSecond")] 		public CString HeadSecond { get; set;}

		[Ordinal(0)] [RED("("headThird")] 		public CString HeadThird { get; set;}

		[Ordinal(0)] [RED("("hingeAxisHead")] 		public CEnum<EAxis> HingeAxisHead { get; set;}

		[Ordinal(0)] [RED("("walkFBP")] 		public SHorseStateOffsets WalkFBP { get; set;}

		[Ordinal(0)] [RED("("trotFBP")] 		public SHorseStateOffsets TrotFBP { get; set;}

		[Ordinal(0)] [RED("("gallopFBP")] 		public SHorseStateOffsets GallopFBP { get; set;}

		[Ordinal(0)] [RED("("canterFBP")] 		public SHorseStateOffsets CanterFBP { get; set;}

		[Ordinal(0)] [RED("("walkFBN")] 		public SHorseStateOffsets WalkFBN { get; set;}

		[Ordinal(0)] [RED("("trotFBN")] 		public SHorseStateOffsets TrotFBN { get; set;}

		[Ordinal(0)] [RED("("gallopFBN")] 		public SHorseStateOffsets GallopFBN { get; set;}

		[Ordinal(0)] [RED("("canterFBN")] 		public SHorseStateOffsets CanterFBN { get; set;}

		[Ordinal(0)] [RED("("walkLR")] 		public SHorseStateOffsets WalkLR { get; set;}

		[Ordinal(0)] [RED("("trotLR")] 		public SHorseStateOffsets TrotLR { get; set;}

		[Ordinal(0)] [RED("("gallopLR")] 		public SHorseStateOffsets GallopLR { get; set;}

		[Ordinal(0)] [RED("("canterLR")] 		public SHorseStateOffsets CanterLR { get; set;}

		public CBehaviorGraphHorseNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphHorseNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}