using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSpeedModulationNode : CBehaviorGraphValueBaseNode
	{
		[Ordinal(1)] [RED("speedThreshold")] 		public CFloat SpeedThreshold { get; set;}

		[Ordinal(2)] [RED("halfAngle")] 		public CFloat HalfAngle { get; set;}

		[Ordinal(3)] [RED("cachedSpeedNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedNode { get; set;}

		[Ordinal(4)] [RED("cachedDirectionNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDirectionNode { get; set;}

		[Ordinal(5)] [RED("cachedThresholdNode")] 		public CPtr<CBehaviorGraphValueNode> CachedThresholdNode { get; set;}

		public CBehaviorGraphSpeedModulationNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}