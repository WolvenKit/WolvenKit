using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphChooseRecoverFromRagdollAnimNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("mode")] 		public CEnum<EBehaviorGraphChooseRecoverFromRagdollAnimMode> Mode { get; set;}

		[Ordinal(2)] [RED("additionalOneFrameRotationYaw")] 		public CFloat AdditionalOneFrameRotationYaw { get; set;}

		[Ordinal(3)] [RED("pelvisBone")] 		public CName PelvisBone { get; set;}

		[Ordinal(4)] [RED("pelvisBoneFrontAxis")] 		public CEnum<EAxis> PelvisBoneFrontAxis { get; set;}

		[Ordinal(5)] [RED("pelvisBoneFrontAxisInverted")] 		public CBool PelvisBoneFrontAxisInverted { get; set;}

		[Ordinal(6)] [RED("pelvisBoneWeight")] 		public CFloat PelvisBoneWeight { get; set;}

		[Ordinal(7)] [RED("shoulderBone")] 		public CName ShoulderBone { get; set;}

		[Ordinal(8)] [RED("shoulderBoneFrontAxis")] 		public CEnum<EAxis> ShoulderBoneFrontAxis { get; set;}

		[Ordinal(9)] [RED("shoulderBoneFrontAxisInverted")] 		public CBool ShoulderBoneFrontAxisInverted { get; set;}

		[Ordinal(10)] [RED("shoulderBoneWeight")] 		public CFloat ShoulderBoneWeight { get; set;}

		[Ordinal(11)] [RED("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		public CBehaviorGraphChooseRecoverFromRagdollAnimNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}