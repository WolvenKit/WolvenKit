using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskReactionDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("counterChance")] 		public CInt32 CounterChance { get; set;}

		[Ordinal(2)] [RED("dodgeChanceAttacks")] 		public CInt32 DodgeChanceAttacks { get; set;}

		[Ordinal(3)] [RED("dodgeChanceAard")] 		public CInt32 DodgeChanceAard { get; set;}

		[Ordinal(4)] [RED("dodgeChanceIgni")] 		public CInt32 DodgeChanceIgni { get; set;}

		[Ordinal(5)] [RED("dodgeChanceBomb")] 		public CInt32 DodgeChanceBomb { get; set;}

		[Ordinal(6)] [RED("dodgeChanceProjectile")] 		public CInt32 DodgeChanceProjectile { get; set;}

		[Ordinal(7)] [RED("reactionDelay")] 		public CFloat ReactionDelay { get; set;}

		public CBTTaskReactionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskReactionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}