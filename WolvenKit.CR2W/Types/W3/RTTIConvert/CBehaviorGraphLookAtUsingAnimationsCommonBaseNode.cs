using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtUsingAnimationsCommonBaseNode : CBehaviorGraphLookAtUsingAnimationsProcessingNode
	{
		[RED("Additive blend type")] 		public CEnum<EAdditiveType> Additive_blend_type { get; set;}

		[RED("Horizontal blend is first")] 		public CBool Horizontal_blend_is_first { get; set;}

		[RED("Alternative additive mapping")] 		public CBool Alternative_additive_mapping { get; set;}

		public CBehaviorGraphLookAtUsingAnimationsCommonBaseNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphLookAtUsingAnimationsCommonBaseNode(cr2w);

	}
}