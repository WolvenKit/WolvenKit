using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeAtomicPlayAnimationManualMotionExtractionDefinition : CBehTreeNodeAtomicActionDefinition
	{
		[RED("slotName")] 		public CName SlotName { get; set;}

		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("loopIterations")] 		public CUInt32 LoopIterations { get; set;}

		[RED("isTransitionAnimation")] 		public CBool IsTransitionAnimation { get; set;}

		public CBehTreeNodeAtomicPlayAnimationManualMotionExtractionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeAtomicPlayAnimationManualMotionExtractionDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}