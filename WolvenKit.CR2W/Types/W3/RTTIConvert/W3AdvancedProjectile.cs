using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AdvancedProjectile : CThrowable
	{
		[Ordinal(0)] [RED("("projSpeed")] 		public CFloat ProjSpeed { get; set;}

		[Ordinal(0)] [RED("("projAngle")] 		public CFloat ProjAngle { get; set;}

		[Ordinal(0)] [RED("("projDMG")] 		public CFloat ProjDMG { get; set;}

		[Ordinal(0)] [RED("("projSilverDMG")] 		public CFloat ProjSilverDMG { get; set;}

		[Ordinal(0)] [RED("("ignoreArmor")] 		public CBool IgnoreArmor { get; set;}

		[Ordinal(0)] [RED("("projEfect")] 		public CEnum<EEffectType> ProjEfect { get; set;}

		[Ordinal(0)] [RED("("persistFxAfterCollision")] 		public CBool PersistFxAfterCollision { get; set;}

		[Ordinal(0)] [RED("("dealDamageEvenIfDodging")] 		public CBool DealDamageEvenIfDodging { get; set;}

		[Ordinal(0)] [RED("("ignore")] 		public CBool Ignore { get; set;}

		[Ordinal(0)] [RED("("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(0)] [RED("("collidedEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> CollidedEntities { get; set;}

		[Ordinal(0)] [RED("("lifeSpan")] 		public CFloat LifeSpan { get; set;}

		public W3AdvancedProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AdvancedProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}