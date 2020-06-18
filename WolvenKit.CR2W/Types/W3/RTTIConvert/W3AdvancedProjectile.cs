using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AdvancedProjectile : CThrowable
	{
		[RED("projSpeed")] 		public CFloat ProjSpeed { get; set;}

		[RED("projAngle")] 		public CFloat ProjAngle { get; set;}

		[RED("projDMG")] 		public CFloat ProjDMG { get; set;}

		[RED("projSilverDMG")] 		public CFloat ProjSilverDMG { get; set;}

		[RED("ignoreArmor")] 		public CBool IgnoreArmor { get; set;}

		[RED("projEfect")] 		public CEnum<EEffectType> ProjEfect { get; set;}

		[RED("persistFxAfterCollision")] 		public CBool PersistFxAfterCollision { get; set;}

		[RED("dealDamageEvenIfDodging")] 		public CBool DealDamageEvenIfDodging { get; set;}

		public W3AdvancedProjectile(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3AdvancedProjectile(cr2w);

	}
}