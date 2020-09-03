using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeAtomicPlayAnimationDefinition : CBehTreeNodeAtomicActionDefinition
	{
		[Ordinal(1)] [RED("animationName")] 		public CBehTreeValCName AnimationName { get; set;}

		[Ordinal(2)] [RED("slotName")] 		public CBehTreeValCName SlotName { get; set;}

		[Ordinal(3)] [RED("blendInTime")] 		public CBehTreeValFloat BlendInTime { get; set;}

		[Ordinal(4)] [RED("blendOutTime")] 		public CBehTreeValFloat BlendOutTime { get; set;}

		public CBehTreeNodeAtomicPlayAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeAtomicPlayAnimationDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}