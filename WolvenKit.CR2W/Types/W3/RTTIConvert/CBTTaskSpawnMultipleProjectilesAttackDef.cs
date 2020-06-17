using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnMultipleProjectilesAttackDef : CBTTaskSpawnMultipleEntitiesAttackDef
	{
		[RED("projectileAngle")] 		public CFloat ProjectileAngle { get; set;}

		[RED("projectileAngleRandomness")] 		public CFloat ProjectileAngleRandomness { get; set;}

		[RED("projectileSpeed")] 		public CFloat ProjectileSpeed { get; set;}

		[RED("projectileSpeedRandomness")] 		public CFloat ProjectileSpeedRandomness { get; set;}

		[RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		public CBTTaskSpawnMultipleProjectilesAttackDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSpawnMultipleProjectilesAttackDef(cr2w);

	}
}