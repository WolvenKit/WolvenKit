using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSelectionValueNode : CBehaviorGraphValueNode
	{
		[RED("threshold")] 		public CFloat Threshold { get; set;}

		[RED("cachedSelNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSelNode { get; set;}

		[RED("cachedOneNode")] 		public CPtr<CBehaviorGraphValueNode> CachedOneNode { get; set;}

		[RED("cachedTwoNode")] 		public CPtr<CBehaviorGraphValueNode> CachedTwoNode { get; set;}

		public CBehaviorGraphSelectionValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphSelectionValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}