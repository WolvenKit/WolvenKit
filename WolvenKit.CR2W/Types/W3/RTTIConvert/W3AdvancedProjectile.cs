using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AdvancedProjectile : CThrowable
	{
		[Ordinal(1)] [RED("projSpeed")] 		public CFloat ProjSpeed { get; set;}

		[Ordinal(2)] [RED("projAngle")] 		public CFloat ProjAngle { get; set;}

		[Ordinal(3)] [RED("projDMG")] 		public CFloat ProjDMG { get; set;}

		[Ordinal(4)] [RED("projSilverDMG")] 		public CFloat ProjSilverDMG { get; set;}

		[Ordinal(5)] [RED("ignoreArmor")] 		public CBool IgnoreArmor { get; set;}

		[Ordinal(6)] [RED("projEfect")] 		public CEnum<EEffectType> ProjEfect { get; set;}

		[Ordinal(7)] [RED("persistFxAfterCollision")] 		public CBool PersistFxAfterCollision { get; set;}

		[Ordinal(8)] [RED("dealDamageEvenIfDodging")] 		public CBool DealDamageEvenIfDodging { get; set;}

		[Ordinal(9)] [RED("ignore")] 		public CBool Ignore { get; set;}

		[Ordinal(10)] [RED("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(11)] [RED("collidedEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> CollidedEntities { get; set;}

		[Ordinal(12)] [RED("lifeSpan")] 		public CFloat LifeSpan { get; set;}

		public W3AdvancedProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AdvancedProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}