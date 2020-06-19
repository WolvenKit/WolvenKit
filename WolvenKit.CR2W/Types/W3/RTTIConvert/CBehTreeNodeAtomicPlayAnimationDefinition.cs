using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeAtomicPlayAnimationDefinition : CBehTreeNodeAtomicActionDefinition
	{
		[RED("animationName")] 		public CBehTreeValCName AnimationName { get; set;}

		[RED("slotName")] 		public CBehTreeValCName SlotName { get; set;}

		[RED("blendInTime")] 		public CBehTreeValFloat BlendInTime { get; set;}

		[RED("blendOutTime")] 		public CBehTreeValFloat BlendOutTime { get; set;}

		public CBehTreeNodeAtomicPlayAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeAtomicPlayAnimationDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}