using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicsModifierNode : CBehaviorGraphBaseMimicNode
	{
		[Ordinal(1)] [RED("type")] 		public CEnum<EMimicGeneratorType> Type { get; set;}

		[Ordinal(2)] [RED("cachedWeightVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightVariableNode { get; set;}

		public CBehaviorGraphMimicsModifierNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicsModifierNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}