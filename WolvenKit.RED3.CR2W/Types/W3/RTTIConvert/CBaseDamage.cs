using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBaseDamage : CObject
	{
		[Ordinal(1)] [RED("hitLocation")] 		public Vector HitLocation { get; set;}

		[Ordinal(2)] [RED("momentum")] 		public Vector Momentum { get; set;}

		[Ordinal(3)] [RED("causer")] 		public CHandle<IScriptable> Causer { get; set;}

		[Ordinal(4)] [RED("attacker")] 		public CHandle<CGameplayEntity> Attacker { get; set;}

		[Ordinal(5)] [RED("victim")] 		public CHandle<CGameplayEntity> Victim { get; set;}

		[Ordinal(6)] [RED("hitReactionAnimRequested")] 		public CBool HitReactionAnimRequested { get; set;}

		public CBaseDamage(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}