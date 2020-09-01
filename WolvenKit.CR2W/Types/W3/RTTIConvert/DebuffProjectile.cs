using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class DebuffProjectile : W3AdvancedProjectile
	{
		[Ordinal(0)] [RED("debuffType")] 		public CEnum<EEffectType> DebuffType { get; set;}

		[Ordinal(0)] [RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(0)] [RED("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[Ordinal(0)] [RED("destroyQuen")] 		public CBool DestroyQuen { get; set;}

		[Ordinal(0)] [RED("customDuration")] 		public CFloat CustomDuration { get; set;}

		[Ordinal(0)] [RED("initFxName")] 		public CName InitFxName { get; set;}

		[Ordinal(0)] [RED("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[Ordinal(0)] [RED("specialFxOnVictimName")] 		public CName SpecialFxOnVictimName { get; set;}

		[Ordinal(0)] [RED("applyDebuffIfNoDmgWasDealt")] 		public CBool ApplyDebuffIfNoDmgWasDealt { get; set;}

		[Ordinal(0)] [RED("bounceOnVictimHit")] 		public CBool BounceOnVictimHit { get; set;}

		[Ordinal(0)] [RED("signalDamageInstigatedEvent")] 		public CBool SignalDamageInstigatedEvent { get; set;}

		[Ordinal(0)] [RED("destroyAfterFloat")] 		public CFloat DestroyAfterFloat { get; set;}

		[Ordinal(0)] [RED("stopProjectileAfterCollision")] 		public CBool StopProjectileAfterCollision { get; set;}

		[Ordinal(0)] [RED("sendGameplayEventToVicitm")] 		public CName SendGameplayEventToVicitm { get; set;}

		public DebuffProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new DebuffProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}