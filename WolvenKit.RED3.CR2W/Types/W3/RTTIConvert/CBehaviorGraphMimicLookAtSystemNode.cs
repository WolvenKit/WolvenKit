using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicLookAtSystemNode : CBehaviorGraphBaseMimicNode
	{
		[Ordinal(1)] [RED("cachedTargetNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

		[Ordinal(2)] [RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[Ordinal(3)] [RED("cachedLevelVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedLevelVariableNode { get; set;}

		[Ordinal(4)] [RED("eyeHorLeftTrack")] 		public CString EyeHorLeftTrack { get; set;}

		[Ordinal(5)] [RED("eyeVerLeftTrack")] 		public CString EyeVerLeftTrack { get; set;}

		[Ordinal(6)] [RED("eyeHorRightTrack")] 		public CString EyeHorRightTrack { get; set;}

		[Ordinal(7)] [RED("eyeVerRightTrack")] 		public CString EyeVerRightTrack { get; set;}

		[Ordinal(8)] [RED("eyeLeftPlacerBone")] 		public CString EyeLeftPlacerBone { get; set;}

		[Ordinal(9)] [RED("eyeRightPlacerBone")] 		public CString EyeRightPlacerBone { get; set;}

		[Ordinal(10)] [RED("eyeHorMax")] 		public CFloat EyeHorMax { get; set;}

		[Ordinal(11)] [RED("eyeVerMax")] 		public CFloat EyeVerMax { get; set;}

		[Ordinal(12)] [RED("dampTime")] 		public CFloat DampTime { get; set;}

		[Ordinal(13)] [RED("dampCurve")] 		public CPtr<CCurve> DampCurve { get; set;}

		public CBehaviorGraphMimicLookAtSystemNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}