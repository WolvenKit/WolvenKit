using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCachedCombatMessage : CVariable
	{
		[Ordinal(1)] [RED("finalIncomingDamage")] 		public CFloat FinalIncomingDamage { get; set;}

		[Ordinal(2)] [RED("resistPoints")] 		public CFloat ResistPoints { get; set;}

		[Ordinal(3)] [RED("resistPercents")] 		public CFloat ResistPercents { get; set;}

		[Ordinal(4)] [RED("finalDamage")] 		public CFloat FinalDamage { get; set;}

		[Ordinal(5)] [RED("attacker")] 		public CHandle<CGameplayEntity> Attacker { get; set;}

		[Ordinal(6)] [RED("victim")] 		public CHandle<CGameplayEntity> Victim { get; set;}

		public SCachedCombatMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCachedCombatMessage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}