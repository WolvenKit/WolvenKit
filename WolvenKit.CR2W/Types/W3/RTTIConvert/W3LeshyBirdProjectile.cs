using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LeshyBirdProjectile : CProjectileTrajectory
	{
		[Ordinal(0)] [RED("("fxEntityTemplate")] 		public CHandle<CEntityTemplate> FxEntityTemplate { get; set;}

		[Ordinal(0)] [RED("("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[Ordinal(0)] [RED("("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(0)] [RED("("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(0)] [RED("("projPos")] 		public Vector ProjPos { get; set;}

		[Ordinal(0)] [RED("("projRot")] 		public EulerAngles ProjRot { get; set;}

		[Ordinal(0)] [RED("("projExpired")] 		public CBool ProjExpired { get; set;}

		public W3LeshyBirdProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LeshyBirdProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}