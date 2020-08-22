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
		[RED("cachedLevelVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedLevelVariableNode { get; set;}

		[RED("cachedWeightsVariableNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedWeightsVariableNode { get; set;}

		[RED("cachedLimitVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedLimitVariableNode { get; set;}

		[RED("cachedCompressedDataVariableNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedCompressedDataVariableNode { get; set;}

		[RED("firstBone")] 		public CString FirstBone { get; set;}

		[RED("secondBone")] 		public CString SecondBone { get; set;}

		[RED("thirdBone")] 		public CString ThirdBone { get; set;}

		[RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[RED("deadZone")] 		public CFloat DeadZone { get; set;}

		[RED("deadZoneDist")] 		public CFloat DeadZoneDist { get; set;}

		[RED("limitDampTime")] 		public CFloat LimitDampTime { get; set;}

		[RED("levelDampTime")] 		public CFloat LevelDampTime { get; set;}

		[RED("internalDampCurve")] 		public CPtr<CCurve> InternalDampCurve { get; set;}

		[RED("dampForFirstTarget")] 		public CFloat DampForFirstTarget { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("firstWeight")] 		public CFloat FirstWeight { get; set;}

		[RED("secondWeight")] 		public CFloat SecondWeight { get; set;}

		[RED("thirdWeight")] 		public CFloat ThirdWeight { get; set;}

		public CBehaviorGraphLookAtSystemNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphLookAtSystemNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}