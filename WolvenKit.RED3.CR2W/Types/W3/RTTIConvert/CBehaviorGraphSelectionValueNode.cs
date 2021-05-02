using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSelectionValueNode : CBehaviorGraphValueNode
	{
		[Ordinal(1)] [RED("threshold")] 		public CFloat Threshold { get; set;}

		[Ordinal(2)] [RED("cachedSelNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSelNode { get; set;}

		[Ordinal(3)] [RED("cachedOneNode")] 		public CPtr<CBehaviorGraphValueNode> CachedOneNode { get; set;}

		[Ordinal(4)] [RED("cachedTwoNode")] 		public CPtr<CBehaviorGraphValueNode> CachedTwoNode { get; set;}

		public CBehaviorGraphSelectionValueNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphSelectionValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}