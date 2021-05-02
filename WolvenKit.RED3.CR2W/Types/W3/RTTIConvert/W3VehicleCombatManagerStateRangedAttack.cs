using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3VehicleCombatManagerStateRangedAttack : CScriptableState
	{
		[Ordinal(1)] [RED("rider")] 		public CHandle<CR4Player> Rider { get; set;}

		[Ordinal(2)] [RED("aiming")] 		public CBool Aiming { get; set;}

		[Ordinal(3)] [RED("fire")] 		public CBool Fire { get; set;}

		[Ordinal(4)] [RED("wasAborted")] 		public CBool WasAborted { get; set;}

		[Ordinal(5)] [RED("horizontalVal")] 		public CFloat HorizontalVal { get; set;}

		public W3VehicleCombatManagerStateRangedAttack(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3VehicleCombatManagerStateRangedAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}