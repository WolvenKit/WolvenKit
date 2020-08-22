using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LeshyRootProjectile : CProjectileTrajectory
	{
		[RED("fxEntityTemplate")] 		public CHandle<CEntityTemplate> FxEntityTemplate { get; set;}

		[RED("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[RED("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[RED("projPos")] 		public Vector ProjPos { get; set;}

		[RED("projRot")] 		public EulerAngles ProjRot { get; set;}

		[RED("projExpired")] 		public CBool ProjExpired { get; set;}

		[RED("collisions")] 		public CInt32 Collisions { get; set;}

		public W3LeshyRootProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LeshyRootProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}