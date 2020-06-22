using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnMultipleProjectilesAttack : CBTTaskSpawnMultipleEntitiesAttack
	{
		[RED("projectileAngle")] 		public CFloat ProjectileAngle { get; set;}

		[RED("projectileAngleRandomness")] 		public CFloat ProjectileAngleRandomness { get; set;}

		[RED("projectileSpeed")] 		public CFloat ProjectileSpeed { get; set;}

		[RED("projectileSpeedRandomness")] 		public CFloat ProjectileSpeedRandomness { get; set;}

		[RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		public CBTTaskSpawnMultipleProjectilesAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnMultipleProjectilesAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}