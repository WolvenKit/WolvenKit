using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPhysicsDestructionAdditionalInfo : CVariable
	{
		[RED("initialVelocity")] 		public Vector InitialVelocity { get; set;}

		[RED("overrideCollisionMasks")] 		public CBool OverrideCollisionMasks { get; set;}

		[RED("m_collisionType")] 		public CPhysicalCollision M_collisionType { get; set;}

		public SPhysicsDestructionAdditionalInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPhysicsDestructionAdditionalInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}