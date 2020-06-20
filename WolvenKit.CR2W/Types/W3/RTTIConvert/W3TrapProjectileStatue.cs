using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapProjectileStatue : W3Trap
	{
		[RED("m_Projectile")] 		public CHandle<CEntityTemplate> M_Projectile { get; set;}

		[RED("m_IsStatic")] 		public CBool M_IsStatic { get; set;}

		[RED("m_RotationSpeed")] 		public CFloat M_RotationSpeed { get; set;}

		[RED("m_FirstShootDelay")] 		public CFloat M_FirstShootDelay { get; set;}

		[RED("m_FireRate")] 		public CFloat M_FireRate { get; set;}

		[RED("m_MaxShots")] 		public CFloat M_MaxShots { get; set;}

		[RED("m_MinAngleToStartShooting")] 		public CFloat M_MinAngleToStartShooting { get; set;}

		[RED("m_MaxAimingPitchCorrection")] 		public CFloat M_MaxAimingPitchCorrection { get; set;}

		[RED("m_TargetPositionPrediction")] 		public CFloat M_TargetPositionPrediction { get; set;}

		[RED("m_ProjectileIsCocked")] 		public CBool M_ProjectileIsCocked { get; set;}

		[RED("m_ProjectileSpeed")] 		public CFloat M_ProjectileSpeed { get; set;}

		[RED("m_ProjectileLifeSpan")] 		public CFloat M_ProjectileLifeSpan { get; set;}

		[RED("m_ProjectileFollowTarget")] 		public CBool M_ProjectileFollowTarget { get; set;}

		public W3TrapProjectileStatue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapProjectileStatue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}