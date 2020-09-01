using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicLookAtSystemNode : CBehaviorGraphBaseMimicNode
	{
		[Ordinal(0)] [RED("("cachedTargetNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

		[Ordinal(0)] [RED("("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[Ordinal(0)] [RED("("cachedLevelVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedLevelVariableNode { get; set;}

		[Ordinal(0)] [RED("("eyeHorLeftTrack")] 		public CString EyeHorLeftTrack { get; set;}

		[Ordinal(0)] [RED("("eyeVerLeftTrack")] 		public CString EyeVerLeftTrack { get; set;}

		[Ordinal(0)] [RED("("eyeHorRightTrack")] 		public CString EyeHorRightTrack { get; set;}

		[Ordinal(0)] [RED("("eyeVerRightTrack")] 		public CString EyeVerRightTrack { get; set;}

		[Ordinal(0)] [RED("("eyeLeftPlacerBone")] 		public CString EyeLeftPlacerBone { get; set;}

		[Ordinal(0)] [RED("("eyeRightPlacerBone")] 		public CString EyeRightPlacerBone { get; set;}

		[Ordinal(0)] [RED("("eyeHorMax")] 		public CFloat EyeHorMax { get; set;}

		[Ordinal(0)] [RED("("eyeVerMax")] 		public CFloat EyeVerMax { get; set;}

		[Ordinal(0)] [RED("("dampTime")] 		public CFloat DampTime { get; set;}

		[Ordinal(0)] [RED("("dampCurve")] 		public CPtr<CCurve> DampCurve { get; set;}

		public CBehaviorGraphMimicLookAtSystemNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicLookAtSystemNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}