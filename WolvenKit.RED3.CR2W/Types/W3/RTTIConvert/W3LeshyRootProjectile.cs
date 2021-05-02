using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LeshyRootProjectile : CProjectileTrajectory
	{
		[Ordinal(1)] [RED("fxEntityTemplate")] 		public CHandle<CEntityTemplate> FxEntityTemplate { get; set;}

		[Ordinal(2)] [RED("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[Ordinal(3)] [RED("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(4)] [RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(5)] [RED("projPos")] 		public Vector ProjPos { get; set;}

		[Ordinal(6)] [RED("projRot")] 		public EulerAngles ProjRot { get; set;}

		[Ordinal(7)] [RED("projExpired")] 		public CBool ProjExpired { get; set;}

		[Ordinal(8)] [RED("collisions")] 		public CInt32 Collisions { get; set;}

		public W3LeshyRootProjectile(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}