using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlayer : CActor
	{
		[RED("npcVoicesetCooldown")] 		public CFloat NpcVoicesetCooldown { get; set;}

		[RED("presenceInterestPoint")] 		public CPtr<CInterestPoint> PresenceInterestPoint { get; set;}

		[RED("slowMovementInterestPoint")] 		public CPtr<CInterestPoint> SlowMovementInterestPoint { get; set;}

		[RED("fastMovementInterestPoint")] 		public CPtr<CInterestPoint> FastMovementInterestPoint { get; set;}

		[RED("weaponDrawnInterestPoint")] 		public CPtr<CInterestPoint> WeaponDrawnInterestPoint { get; set;}

		[RED("weaponDrawMomentInterestPoint")] 		public CPtr<CInterestPoint> WeaponDrawMomentInterestPoint { get; set;}

		[RED("visionInterestPoint")] 		public CPtr<CInterestPoint> VisionInterestPoint { get; set;}

		[RED("isMovable")] 		public CBool IsMovable { get; set;}

		[RED("enemyUpscaling")] 		public CBool EnemyUpscaling { get; set;}

		[RED("FarZoneDistMax")] 		public CFloat FarZoneDistMax { get; set;}

		[RED("DangerZoneDistMax")] 		public CFloat DangerZoneDistMax { get; set;}

		[RED("softLockDist")] 		public CFloat SoftLockDist { get; set;}

		[RED("softLockFrameSize")] 		public CFloat SoftLockFrameSize { get; set;}

		public CPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}