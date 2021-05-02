using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMagicBombEntity : CGameplayEntity
	{
		[Ordinal(1)] [RED("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[Ordinal(2)] [RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[Ordinal(3)] [RED("settlingTime")] 		public CFloat SettlingTime { get; set;}

		[Ordinal(4)] [RED("entitiesInRange", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInRange { get; set;}

		[Ordinal(5)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(6)] [RED("damage")] 		public CHandle<W3DamageAction> Damage { get; set;}

		[Ordinal(7)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		public CMagicBombEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMagicBombEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}