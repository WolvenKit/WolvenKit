using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicsGeneratorNode : CBehaviorGraphNode
	{
		[RED("trackName")] 		public CString TrackName { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("cachedWeightVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightVariableNode { get; set;}

		[RED("cachedPoseNumVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedPoseNumVariableNode { get; set;}

		public CBehaviorGraphMimicsGeneratorNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphMimicsGeneratorNode(cr2w);

	}
}