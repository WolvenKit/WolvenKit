using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBaseDamage : CObject
	{
		[RED("hitLocation")] 		public Vector HitLocation { get; set;}

		[RED("momentum")] 		public Vector Momentum { get; set;}

		[RED("causer")] 		public CHandle<IScriptable> Causer { get; set;}

		[RED("attacker")] 		public CHandle<CGameplayEntity> Attacker { get; set;}

		[RED("victim")] 		public CHandle<CGameplayEntity> Victim { get; set;}

		[RED("hitReactionAnimRequested")] 		public CBool HitReactionAnimRequested { get; set;}

		public CBaseDamage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBaseDamage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}