using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphChooseRecoverFromRagdollAnimNode : CBehaviorGraphNode
	{
		[RED("mode")] 		public CEnum<EBehaviorGraphChooseRecoverFromRagdollAnimMode> Mode { get; set;}

		[RED("additionalOneFrameRotationYaw")] 		public CFloat AdditionalOneFrameRotationYaw { get; set;}

		[RED("pelvisBone")] 		public CName PelvisBone { get; set;}

		[RED("pelvisBoneFrontAxis")] 		public CEnum<EAxis> PelvisBoneFrontAxis { get; set;}

		[RED("pelvisBoneFrontAxisInverted")] 		public CBool PelvisBoneFrontAxisInverted { get; set;}

		[RED("pelvisBoneWeight")] 		public CFloat PelvisBoneWeight { get; set;}

		[RED("shoulderBone")] 		public CName ShoulderBone { get; set;}

		[RED("shoulderBoneFrontAxis")] 		public CEnum<EAxis> ShoulderBoneFrontAxis { get; set;}

		[RED("shoulderBoneFrontAxisInverted")] 		public CBool ShoulderBoneFrontAxisInverted { get; set;}

		[RED("shoulderBoneWeight")] 		public CFloat ShoulderBoneWeight { get; set;}

		[RED("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		public CBehaviorGraphChooseRecoverFromRagdollAnimNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphChooseRecoverFromRagdollAnimNode(cr2w);

	}
}