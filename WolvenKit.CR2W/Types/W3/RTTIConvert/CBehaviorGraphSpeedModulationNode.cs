using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSpeedModulationNode : CBehaviorGraphValueBaseNode
	{
		[RED("speedThreshold")] 		public CFloat SpeedThreshold { get; set;}

		[RED("halfAngle")] 		public CFloat HalfAngle { get; set;}

		[RED("cachedSpeedNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedNode { get; set;}

		[RED("cachedDirectionNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDirectionNode { get; set;}

		[RED("cachedThresholdNode")] 		public CPtr<CBehaviorGraphValueNode> CachedThresholdNode { get; set;}

		public CBehaviorGraphSpeedModulationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphSpeedModulationNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}