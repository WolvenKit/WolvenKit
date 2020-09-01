using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimatedComponentPhysicsRepresentation : CObject
	{
		[Ordinal(1)] [RED("ragdoll")] 		public CHandle<CRagdoll> Ragdoll { get; set;}

		[Ordinal(2)] [RED("ragdollCollisionType")] 		public CPhysicalCollision RagdollCollisionType { get; set;}

		[Ordinal(3)] [RED("ragdollAlwaysEnabled")] 		public CBool RagdollAlwaysEnabled { get; set;}

		[Ordinal(4)] [RED("allowRagdollInCutscene")] 		public CBool AllowRagdollInCutscene { get; set;}

		public CAnimatedComponentPhysicsRepresentation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimatedComponentPhysicsRepresentation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}