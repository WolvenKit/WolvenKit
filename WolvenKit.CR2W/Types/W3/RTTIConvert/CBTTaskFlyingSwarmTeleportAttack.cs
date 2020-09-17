using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyingSwarmTeleportAttack : CBTTaskFlyingSwarmTeleport
	{
		[Ordinal(1)] [RED("boidRequestCompletedEvents")] 		public CInt32 BoidRequestCompletedEvents { get; set;}

		[Ordinal(2)] [RED("despawnAfterAttackTime")] 		public CFloat DespawnAfterAttackTime { get; set;}

		[Ordinal(3)] [RED("attackCompleted")] 		public CBool AttackCompleted { get; set;}

		[Ordinal(4)] [RED("res2")] 		public CBool Res2 { get; set;}

		[Ordinal(5)] [RED("attackTimeStamp")] 		public CFloat AttackTimeStamp { get; set;}

		public CBTTaskFlyingSwarmTeleportAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyingSwarmTeleportAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}