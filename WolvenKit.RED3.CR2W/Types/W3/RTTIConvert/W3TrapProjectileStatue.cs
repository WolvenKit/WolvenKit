using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapProjectileStatue : W3Trap
	{
		[Ordinal(1)] [RED("m_Projectile")] 		public CHandle<CEntityTemplate> M_Projectile { get; set;}

		[Ordinal(2)] [RED("m_IsStatic")] 		public CBool M_IsStatic { get; set;}

		[Ordinal(3)] [RED("m_RotationSpeed")] 		public CFloat M_RotationSpeed { get; set;}

		[Ordinal(4)] [RED("m_FirstShootDelay")] 		public CFloat M_FirstShootDelay { get; set;}

		[Ordinal(5)] [RED("m_FireRate")] 		public CFloat M_FireRate { get; set;}

		[Ordinal(6)] [RED("m_MaxShots")] 		public CFloat M_MaxShots { get; set;}

		[Ordinal(7)] [RED("m_MinAngleToStartShooting")] 		public CFloat M_MinAngleToStartShooting { get; set;}

		[Ordinal(8)] [RED("m_MaxAimingPitchCorrection")] 		public CFloat M_MaxAimingPitchCorrection { get; set;}

		[Ordinal(9)] [RED("m_TargetPositionPrediction")] 		public CFloat M_TargetPositionPrediction { get; set;}

		[Ordinal(10)] [RED("m_ProjectileIsCocked")] 		public CBool M_ProjectileIsCocked { get; set;}

		[Ordinal(11)] [RED("m_ProjectileSpeed")] 		public CFloat M_ProjectileSpeed { get; set;}

		[Ordinal(12)] [RED("m_ProjectileLifeSpan")] 		public CFloat M_ProjectileLifeSpan { get; set;}

		[Ordinal(13)] [RED("m_ProjectileFollowTarget")] 		public CBool M_ProjectileFollowTarget { get; set;}

		[Ordinal(14)] [RED("m_DelayUntilNextProjectile")] 		public CFloat M_DelayUntilNextProjectile { get; set;}

		[Ordinal(15)] [RED("m_ShotsLeft")] 		public CFloat M_ShotsLeft { get; set;}

		[Ordinal(16)] [RED("m_CockedProjectile")] 		public CHandle<W3AdvancedProjectile> M_CockedProjectile { get; set;}

		[Ordinal(17)] [RED("m_DelayToNextSorting")] 		public CFloat M_DelayToNextSorting { get; set;}

		public W3TrapProjectileStatue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapProjectileStatue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}