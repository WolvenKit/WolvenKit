using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtUsingEmbeddedAnimationsNode : CBehaviorGraphLookAtUsingAnimationsCommonBaseNode
	{
		[RED("useHorizontalAnimations")] 		public CBool UseHorizontalAnimations { get; set;}

		[RED("useVerticalAnimations")] 		public CBool UseVerticalAnimations { get; set;}

		[RED("Default pair")] 		public SLookAtAnimationPairDefinition Default_pair { get; set;}

		[RED("Input based pairs", 2,0)] 		public CArray<SLookAtAnimationPairInputBasedDefinition> Input_based_pairs { get; set;}

		[RED("Pairs", 2,0)] 		public CArray<SLookAtAnimationPairDefinition> Pairs { get; set;}

		public CBehaviorGraphLookAtUsingEmbeddedAnimationsNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphLookAtUsingEmbeddedAnimationsNode(cr2w);

	}
}