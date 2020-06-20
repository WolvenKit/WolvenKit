using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class DebuffProjectile : W3AdvancedProjectile
	{
		[RED("debuffType")] 		public CEnum<EEffectType> DebuffType { get; set;}

		[RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[RED("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[RED("destroyQuen")] 		public CBool DestroyQuen { get; set;}

		[RED("customDuration")] 		public CFloat CustomDuration { get; set;}

		[RED("initFxName")] 		public CName InitFxName { get; set;}

		[RED("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[RED("specialFxOnVictimName")] 		public CName SpecialFxOnVictimName { get; set;}

		[RED("applyDebuffIfNoDmgWasDealt")] 		public CBool ApplyDebuffIfNoDmgWasDealt { get; set;}

		[RED("bounceOnVictimHit")] 		public CBool BounceOnVictimHit { get; set;}

		[RED("signalDamageInstigatedEvent")] 		public CBool SignalDamageInstigatedEvent { get; set;}

		[RED("destroyAfterFloat")] 		public CFloat DestroyAfterFloat { get; set;}

		[RED("stopProjectileAfterCollision")] 		public CBool StopProjectileAfterCollision { get; set;}

		[RED("sendGameplayEventToVicitm")] 		public CName SendGameplayEventToVicitm { get; set;}

		public DebuffProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new DebuffProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}