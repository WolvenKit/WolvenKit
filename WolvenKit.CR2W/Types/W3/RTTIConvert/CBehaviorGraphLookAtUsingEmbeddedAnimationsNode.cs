using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtUsingEmbeddedAnimationsNode : CBehaviorGraphLookAtUsingAnimationsCommonBaseNode
	{
		[Ordinal(1)] [RED("useHorizontalAnimations")] 		public CBool UseHorizontalAnimations { get; set;}

		[Ordinal(2)] [RED("useVerticalAnimations")] 		public CBool UseVerticalAnimations { get; set;}

		[Ordinal(3)] [RED("Default pair")] 		public SLookAtAnimationPairDefinition Default_pair { get; set;}

		[Ordinal(4)] [RED("Input based pairs", 2,0)] 		public CArray<SLookAtAnimationPairInputBasedDefinition> Input_based_pairs { get; set;}

		[Ordinal(5)] [RED("Pairs", 2,0)] 		public CArray<SLookAtAnimationPairDefinition> Pairs { get; set;}

		public CBehaviorGraphLookAtUsingEmbeddedAnimationsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphLookAtUsingEmbeddedAnimationsNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}