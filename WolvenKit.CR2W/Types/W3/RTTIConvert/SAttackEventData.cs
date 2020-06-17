using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAttackEventData : CVariable
	{
		[RED("animData")] 		public CPreAttackEventData AnimData { get; set;}

		[RED("weaponId")] 		public SItemUniqueId WeaponId { get; set;}

		[RED("parriedBy", 2,0)] 		public CArray<CHandle<CActor>> ParriedBy { get; set;}

		public SAttackEventData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAttackEventData(cr2w);

	}
}