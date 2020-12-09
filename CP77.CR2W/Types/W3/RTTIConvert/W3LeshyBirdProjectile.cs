using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LeshyBirdProjectile : CProjectileTrajectory
	{
		[Ordinal(1)] [RED("fxEntityTemplate")] 		public CHandle<CEntityTemplate> FxEntityTemplate { get; set;}

		[Ordinal(2)] [RED("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[Ordinal(3)] [RED("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(4)] [RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(5)] [RED("projPos")] 		public Vector ProjPos { get; set;}

		[Ordinal(6)] [RED("projRot")] 		public EulerAngles ProjRot { get; set;}

		[Ordinal(7)] [RED("projExpired")] 		public CBool ProjExpired { get; set;}

		public W3LeshyBirdProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LeshyBirdProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}