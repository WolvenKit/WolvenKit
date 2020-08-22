using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBiesCharge : CBTTask3StateAttack
	{
		[RED("endStuck")] 		public CEnum<EAttackType> EndStuck { get; set;}

		[RED("endHit")] 		public CEnum<EAttackType> EndHit { get; set;}

		[RED("bCollisionWithObstacle")] 		public CBool BCollisionWithObstacle { get; set;}

		[RED("bCollisionWithActor")] 		public CBool BCollisionWithActor { get; set;}

		[RED("stuckTime")] 		public CFloat StuckTime { get; set;}

		[RED("loopStart")] 		public CBool LoopStart { get; set;}

		[RED("cameraIndex")] 		public CInt32 CameraIndex { get; set;}

		[RED("isEnding")] 		public CBool IsEnding { get; set;}

		[RED("collidedActor")] 		public CHandle<CActor> CollidedActor { get; set;}

		public CBTTaskBiesCharge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskBiesCharge(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}