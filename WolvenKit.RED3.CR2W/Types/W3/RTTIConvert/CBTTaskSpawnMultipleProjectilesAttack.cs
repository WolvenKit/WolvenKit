using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnMultipleProjectilesAttack : CBTTaskSpawnMultipleEntitiesAttack
	{
		[Ordinal(1)] [RED("projectileAngle")] 		public CFloat ProjectileAngle { get; set;}

		[Ordinal(2)] [RED("projectileAngleRandomness")] 		public CFloat ProjectileAngleRandomness { get; set;}

		[Ordinal(3)] [RED("projectileSpeed")] 		public CFloat ProjectileSpeed { get; set;}

		[Ordinal(4)] [RED("projectileSpeedRandomness")] 		public CFloat ProjectileSpeedRandomness { get; set;}

		[Ordinal(5)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		public CBTTaskSpawnMultipleProjectilesAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnMultipleProjectilesAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}