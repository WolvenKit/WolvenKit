using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSlotInfo : CVariable
	{
		[RED("slotName")] 		public CName SlotName { get; set;}

		[RED("parentSlotName")] 		public CName ParentSlotName { get; set;}

		[RED("parentSlotIndex")] 		public CInt32 ParentSlotIndex { get; set;}

		[RED("relativePosition")] 		public Vector RelativePosition { get; set;}

		[RED("relativeRotation")] 		public EulerAngles RelativeRotation { get; set;}

		public SSlotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSlotInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}