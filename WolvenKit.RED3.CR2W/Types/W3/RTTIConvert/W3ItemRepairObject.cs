using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ItemRepairObject : CR4MapPinEntity
	{
		[Ordinal(1)] [RED("repairSword")] 		public CBool RepairSword { get; set;}

		[Ordinal(2)] [RED("repairArmor")] 		public CBool RepairArmor { get; set;}

		[Ordinal(3)] [RED("chargesArmor")] 		public CInt32 ChargesArmor { get; set;}

		[Ordinal(4)] [RED("chargesWeapon")] 		public CInt32 ChargesWeapon { get; set;}

		[Ordinal(5)] [RED("interactionComp")] 		public CHandle<CInteractionComponent> InteractionComp { get; set;}

		public W3ItemRepairObject(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}