using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtUsingAnimationsCommonBaseNode : CBehaviorGraphLookAtUsingAnimationsProcessingNode
	{
		[Ordinal(1)] [RED("Additive blend type")] 		public CEnum<EAdditiveType> Additive_blend_type { get; set;}

		[Ordinal(2)] [RED("Horizontal blend is first")] 		public CBool Horizontal_blend_is_first { get; set;}

		[Ordinal(3)] [RED("Alternative additive mapping")] 		public CBool Alternative_additive_mapping { get; set;}

		public CBehaviorGraphLookAtUsingAnimationsCommonBaseNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphLookAtUsingAnimationsCommonBaseNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}