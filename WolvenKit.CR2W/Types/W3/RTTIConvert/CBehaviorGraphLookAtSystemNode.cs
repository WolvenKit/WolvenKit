using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtSystemNode : CBehaviorGraphConstraintNode
	{
		[Ordinal(0)] [RED("("cachedLevelVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedLevelVariableNode { get; set;}

		[Ordinal(0)] [RED("("cachedWeightsVariableNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedWeightsVariableNode { get; set;}

		[Ordinal(0)] [RED("("cachedLimitVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedLimitVariableNode { get; set;}

		[Ordinal(0)] [RED("("cachedCompressedDataVariableNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedCompressedDataVariableNode { get; set;}

		[Ordinal(0)] [RED("("firstBone")] 		public CString FirstBone { get; set;}

		[Ordinal(0)] [RED("("secondBone")] 		public CString SecondBone { get; set;}

		[Ordinal(0)] [RED("("thirdBone")] 		public CString ThirdBone { get; set;}

		[Ordinal(0)] [RED("("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(0)] [RED("("deadZone")] 		public CFloat DeadZone { get; set;}

		[Ordinal(0)] [RED("("deadZoneDist")] 		public CFloat DeadZoneDist { get; set;}

		[Ordinal(0)] [RED("("limitDampTime")] 		public CFloat LimitDampTime { get; set;}

		[Ordinal(0)] [RED("("levelDampTime")] 		public CFloat LevelDampTime { get; set;}

		[Ordinal(0)] [RED("("internalDampCurve")] 		public CPtr<CCurve> InternalDampCurve { get; set;}

		[Ordinal(0)] [RED("("dampForFirstTarget")] 		public CFloat DampForFirstTarget { get; set;}

		[Ordinal(0)] [RED("("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("("firstWeight")] 		public CFloat FirstWeight { get; set;}

		[Ordinal(0)] [RED("("secondWeight")] 		public CFloat SecondWeight { get; set;}

		[Ordinal(0)] [RED("("thirdWeight")] 		public CFloat ThirdWeight { get; set;}

		public CBehaviorGraphLookAtSystemNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphLookAtSystemNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}