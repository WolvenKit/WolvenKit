using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIPlayAnimationSlotAction : IAIActionTree
	{
		[Ordinal(1)] [RED("animName")] 		public CName AnimName { get; set;}

		[Ordinal(2)] [RED("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(3)] [RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[Ordinal(4)] [RED("blendOutTime")] 		public CFloat BlendOutTime { get; set;}

		public CAIPlayAnimationSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIPlayAnimationSlotAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}