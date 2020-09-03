using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimationSlotNode : CBehaviorGraphAnimationBaseSlotNode
	{
		[Ordinal(1)] [RED("cachedBaseInputNode")] 		public CPtr<CBehaviorGraphNode> CachedBaseInputNode { get; set;}

		[Ordinal(2)] [RED("startEvtName")] 		public CName StartEvtName { get; set;}

		[Ordinal(3)] [RED("stopEvtName")] 		public CName StopEvtName { get; set;}

		public CBehaviorGraphAnimationSlotNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimationSlotNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}