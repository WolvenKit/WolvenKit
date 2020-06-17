using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicGainNode : CBehaviorGraphBaseMimicNode
	{
		[RED("gain")] 		public CFloat Gain { get; set;}

		[RED("min")] 		public CFloat Min { get; set;}

		[RED("max")] 		public CFloat Max { get; set;}

		[RED("cachedGainValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedGainValueNode { get; set;}

		public CBehaviorGraphMimicGainNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphMimicGainNode(cr2w);

	}
}