using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMagicBombEntity : CGameplayEntity
	{
		[Ordinal(0)] [RED("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[Ordinal(0)] [RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[Ordinal(0)] [RED("settlingTime")] 		public CFloat SettlingTime { get; set;}

		[Ordinal(0)] [RED("entitiesInRange", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInRange { get; set;}

		[Ordinal(0)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(0)] [RED("damage")] 		public CHandle<W3DamageAction> Damage { get; set;}

		[Ordinal(0)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		public CMagicBombEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMagicBombEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}