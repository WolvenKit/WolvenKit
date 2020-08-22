using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMagicCoilAttack : CBTTaskAttack
	{
		[RED("fxNames", 2,0)] 		public CArray<CName> FxNames { get; set;}

		[RED("playFxInterval")] 		public CFloat PlayFxInterval { get; set;}

		[RED("shootProjectileRange")] 		public CFloat ShootProjectileRange { get; set;}

		[RED("shootProjectileInterval")] 		public CFloat ShootProjectileInterval { get; set;}

		[RED("deactivateAfter")] 		public CFloat DeactivateAfter { get; set;}

		[RED("setBehVarOnDeactivation")] 		public CName SetBehVarOnDeactivation { get; set;}

		[RED("setBehVarValueOnDeactivation")] 		public CFloat SetBehVarValueOnDeactivation { get; set;}

		[RED("useActorHeading")] 		public CBool UseActorHeading { get; set;}

		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("projResourceName")] 		public CName ProjResourceName { get; set;}

		[RED("fxOnDamageInstigatedQuen")] 		public CName FxOnDamageInstigatedQuen { get; set;}

		[RED("m_collisionGroups", 2,0)] 		public CArray<CName> M_collisionGroups { get; set;}

		[RED("m_projectile")] 		public CHandle<W3AdvancedProjectile> M_projectile { get; set;}

		[RED("m_projEntity")] 		public CHandle<CEntityTemplate> M_projEntity { get; set;}

		[RED("m_numberOfFxActivated")] 		public CInt32 M_numberOfFxActivated { get; set;}

		[RED("m_activated")] 		public CBool M_activated { get; set;}

		public CBTTaskMagicCoilAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMagicCoilAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}