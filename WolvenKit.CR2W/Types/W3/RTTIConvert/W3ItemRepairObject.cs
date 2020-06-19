using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ItemRepairObject : CR4MapPinEntity
	{
		[RED("repairSword")] 		public CBool RepairSword { get; set;}

		[RED("repairArmor")] 		public CBool RepairArmor { get; set;}

		[RED("chargesArmor")] 		public CInt32 ChargesArmor { get; set;}

		[RED("chargesWeapon")] 		public CInt32 ChargesWeapon { get; set;}

		public W3ItemRepairObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ItemRepairObject(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}