using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphHorseNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("cachedSpeedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedValueNode { get; set;}

		[Ordinal(2)] [RED("speedStep")] 		public CFloat SpeedStep { get; set;}

		[Ordinal(3)] [RED("slopeFBVar")] 		public CName SlopeFBVar { get; set;}

		[Ordinal(4)] [RED("slopeLRVar")] 		public CName SlopeLRVar { get; set;}

		[Ordinal(5)] [RED("firstBoneF")] 		public CString FirstBoneF { get; set;}

		[Ordinal(6)] [RED("secondBoneF")] 		public CString SecondBoneF { get; set;}

		[Ordinal(7)] [RED("thirdBoneF")] 		public CString ThirdBoneF { get; set;}

		[Ordinal(8)] [RED("endBoneF")] 		public CString EndBoneF { get; set;}

		[Ordinal(9)] [RED("hingeAxisF")] 		public CEnum<EAxis> HingeAxisF { get; set;}

		[Ordinal(10)] [RED("firstBoneB")] 		public CString FirstBoneB { get; set;}

		[Ordinal(11)] [RED("secondBoneB")] 		public CString SecondBoneB { get; set;}

		[Ordinal(12)] [RED("thirdBoneB")] 		public CString ThirdBoneB { get; set;}

		[Ordinal(13)] [RED("endBoneB")] 		public CString EndBoneB { get; set;}

		[Ordinal(14)] [RED("hingeAxisB")] 		public CEnum<EAxis> HingeAxisB { get; set;}

		[Ordinal(15)] [RED("root")] 		public CString Root { get; set;}

		[Ordinal(16)] [RED("pelvis")] 		public CString Pelvis { get; set;}

		[Ordinal(17)] [RED("axisRootFB")] 		public CEnum<EAxis> AxisRootFB { get; set;}

		[Ordinal(18)] [RED("axisRootLR")] 		public CEnum<EAxis> AxisRootLR { get; set;}

		[Ordinal(19)] [RED("headFirst")] 		public CString HeadFirst { get; set;}

		[Ordinal(20)] [RED("headSecond")] 		public CString HeadSecond { get; set;}

		[Ordinal(21)] [RED("headThird")] 		public CString HeadThird { get; set;}

		[Ordinal(22)] [RED("hingeAxisHead")] 		public CEnum<EAxis> HingeAxisHead { get; set;}

		[Ordinal(23)] [RED("walkFBP")] 		public SHorseStateOffsets WalkFBP { get; set;}

		[Ordinal(24)] [RED("trotFBP")] 		public SHorseStateOffsets TrotFBP { get; set;}

		[Ordinal(25)] [RED("gallopFBP")] 		public SHorseStateOffsets GallopFBP { get; set;}

		[Ordinal(26)] [RED("canterFBP")] 		public SHorseStateOffsets CanterFBP { get; set;}

		[Ordinal(27)] [RED("walkFBN")] 		public SHorseStateOffsets WalkFBN { get; set;}

		[Ordinal(28)] [RED("trotFBN")] 		public SHorseStateOffsets TrotFBN { get; set;}

		[Ordinal(29)] [RED("gallopFBN")] 		public SHorseStateOffsets GallopFBN { get; set;}

		[Ordinal(30)] [RED("canterFBN")] 		public SHorseStateOffsets CanterFBN { get; set;}

		[Ordinal(31)] [RED("walkLR")] 		public SHorseStateOffsets WalkLR { get; set;}

		[Ordinal(32)] [RED("trotLR")] 		public SHorseStateOffsets TrotLR { get; set;}

		[Ordinal(33)] [RED("gallopLR")] 		public SHorseStateOffsets GallopLR { get; set;}

		[Ordinal(34)] [RED("canterLR")] 		public SHorseStateOffsets CanterLR { get; set;}

		public CBehaviorGraphHorseNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphHorseNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}