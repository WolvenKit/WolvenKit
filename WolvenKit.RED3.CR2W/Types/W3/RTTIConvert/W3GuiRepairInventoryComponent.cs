using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GuiRepairInventoryComponent : W3GuiBaseInventoryComponent
	{
		[Ordinal(1)] [RED("merchantInv")] 		public CHandle<CInventoryComponent> MerchantInv { get; set;}

		[Ordinal(2)] [RED("masteryLevel")] 		public CInt32 MasteryLevel { get; set;}

		[Ordinal(3)] [RED("repairSwords")] 		public CBool RepairSwords { get; set;}

		[Ordinal(4)] [RED("repairArmors")] 		public CBool RepairArmors { get; set;}

		public W3GuiRepairInventoryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3GuiRepairInventoryComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}