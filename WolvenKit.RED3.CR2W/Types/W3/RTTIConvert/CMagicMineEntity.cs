using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMagicMineEntity : CInteractiveEntity
	{
		[Ordinal(1)] [RED("tellTime")] 		public CFloat TellTime { get; set;}

		[Ordinal(2)] [RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[Ordinal(3)] [RED("boatDamageVal")] 		public CFloat BoatDamageVal { get; set;}

		[Ordinal(4)] [RED("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[Ordinal(5)] [RED("mineTrigger")] 		public CHandle<CTriggerAreaComponent> MineTrigger { get; set;}

		public CMagicMineEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMagicMineEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}