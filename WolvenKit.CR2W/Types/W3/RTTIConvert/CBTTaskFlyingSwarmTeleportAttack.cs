using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyingSwarmTeleportAttack : CBTTaskFlyingSwarmTeleport
	{
		[RED("boidRequestCompletedEvents")] 		public CInt32 BoidRequestCompletedEvents { get; set;}

		[RED("despawnAfterAttackTime")] 		public CFloat DespawnAfterAttackTime { get; set;}

		[RED("attackCompleted")] 		public CBool AttackCompleted { get; set;}

		[RED("res2")] 		public CBool Res2 { get; set;}

		[RED("attackTimeStamp")] 		public CFloat AttackTimeStamp { get; set;}

		public CBTTaskFlyingSwarmTeleportAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyingSwarmTeleportAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}