using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskShoot : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(1)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(2)] [RED("attackRange")] 		public CFloat AttackRange { get; set;}

		[Ordinal(3)] [RED("setArrowOnFire")] 		public CBool SetArrowOnFire { get; set;}

		[Ordinal(4)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(5)] [RED("arrow")] 		public CHandle<W3ArrowProjectile> Arrow { get; set;}

		[Ordinal(6)] [RED("projShot")] 		public CBool ProjShot { get; set;}

		public CBTTaskShoot(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}