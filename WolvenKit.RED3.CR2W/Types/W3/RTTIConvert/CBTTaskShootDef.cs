using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskShootDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(2)] [RED("attackRange")] 		public CBehTreeValFloat AttackRange { get; set;}

		[Ordinal(3)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(4)] [RED("setArrowOnFire")] 		public CBehTreeValBool SetArrowOnFire { get; set;}

		public CBTTaskShootDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskShootDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}