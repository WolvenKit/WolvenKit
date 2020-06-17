using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicLipsyncFilterNode : CBehaviorGraphBaseMimicNode
	{
		[RED("lipsyncControlTrack")] 		public CInt32 LipsyncControlTrack { get; set;}

		[RED("lipsyncTrackBeginA")] 		public CInt32 LipsyncTrackBeginA { get; set;}

		[RED("lipsyncTrackEndA")] 		public CInt32 LipsyncTrackEndA { get; set;}

		[RED("lipsyncTrackBeginB")] 		public CInt32 LipsyncTrackBeginB { get; set;}

		[RED("lipsyncTrackEndB")] 		public CInt32 LipsyncTrackEndB { get; set;}

		[RED("lipsyncTrackBeginC")] 		public CInt32 LipsyncTrackBeginC { get; set;}

		[RED("lipsyncTrackEndC")] 		public CInt32 LipsyncTrackEndC { get; set;}

		[RED("cachedFilterInputNode")] 		public CPtr<CBehaviorGraphNode> CachedFilterInputNode { get; set;}

		[RED("cachedWeightValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightValueNode { get; set;}

		public CBehaviorGraphMimicLipsyncFilterNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphMimicLipsyncFilterNode(cr2w);

	}
}