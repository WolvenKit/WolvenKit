using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicLipsyncFilterNode : CBehaviorGraphBaseMimicNode
	{
		[Ordinal(1)] [RED("lipsyncControlTrack")] 		public CInt32 LipsyncControlTrack { get; set;}

		[Ordinal(2)] [RED("lipsyncTrackBeginA")] 		public CInt32 LipsyncTrackBeginA { get; set;}

		[Ordinal(3)] [RED("lipsyncTrackEndA")] 		public CInt32 LipsyncTrackEndA { get; set;}

		[Ordinal(4)] [RED("lipsyncTrackBeginB")] 		public CInt32 LipsyncTrackBeginB { get; set;}

		[Ordinal(5)] [RED("lipsyncTrackEndB")] 		public CInt32 LipsyncTrackEndB { get; set;}

		[Ordinal(6)] [RED("lipsyncTrackBeginC")] 		public CInt32 LipsyncTrackBeginC { get; set;}

		[Ordinal(7)] [RED("lipsyncTrackEndC")] 		public CInt32 LipsyncTrackEndC { get; set;}

		[Ordinal(8)] [RED("cachedFilterInputNode")] 		public CPtr<CBehaviorGraphNode> CachedFilterInputNode { get; set;}

		[Ordinal(9)] [RED("cachedWeightValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightValueNode { get; set;}

		public CBehaviorGraphMimicLipsyncFilterNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicLipsyncFilterNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}