using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtUsingAnimationsNode : CBehaviorGraphLookAtUsingAnimationsCommonBaseNode
	{
		[RED("cachedVerticalAdditiveInputNode")] 		public CPtr<CBehaviorGraphNode> CachedVerticalAdditiveInputNode { get; set;}

		[RED("cachedHorizontalAdditiveInputNode")] 		public CPtr<CBehaviorGraphNode> CachedHorizontalAdditiveInputNode { get; set;}

		public CBehaviorGraphLookAtUsingAnimationsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphLookAtUsingAnimationsNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}