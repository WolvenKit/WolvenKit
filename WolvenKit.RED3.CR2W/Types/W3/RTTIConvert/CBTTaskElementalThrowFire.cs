using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskElementalThrowFire : CBTTaskAttack
	{
		[Ordinal(1)] [RED("projectileEntity")] 		public CHandle<CEntityTemplate> ProjectileEntity { get; set;}

		[Ordinal(2)] [RED("projectile")] 		public CHandle<CProjectileTrajectory> Projectile { get; set;}

		[Ordinal(3)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(4)] [RED("projectileShot")] 		public CBool ProjectileShot { get; set;}

		public CBTTaskElementalThrowFire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskElementalThrowFire(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}