using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeAtomicPlayAnimationManualMotionExtractionDefinition : CBehTreeNodeAtomicActionDefinition
	{
		[Ordinal(1)] [RED("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(2)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(3)] [RED("loopIterations")] 		public CUInt32 LoopIterations { get; set;}

		[Ordinal(4)] [RED("isTransitionAnimation")] 		public CBool IsTransitionAnimation { get; set;}

		public CBehTreeNodeAtomicPlayAnimationManualMotionExtractionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeAtomicPlayAnimationManualMotionExtractionDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}