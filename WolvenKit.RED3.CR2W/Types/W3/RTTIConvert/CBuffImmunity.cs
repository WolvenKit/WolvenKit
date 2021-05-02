using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBuffImmunity : CVariable
	{
		[Ordinal(1)] [RED("immunityTo", 2,0)] 		public CArray<CInt32> ImmunityTo { get; set;}

		[Ordinal(2)] [RED("potion")] 		public CBool Potion { get; set;}

		[Ordinal(3)] [RED("positive")] 		public CBool Positive { get; set;}

		[Ordinal(4)] [RED("negative")] 		public CBool Negative { get; set;}

		[Ordinal(5)] [RED("neutral")] 		public CBool Neutral { get; set;}

		[Ordinal(6)] [RED("immobilize")] 		public CBool Immobilize { get; set;}

		[Ordinal(7)] [RED("confuse")] 		public CBool Confuse { get; set;}

		[Ordinal(8)] [RED("damage")] 		public CBool Damage { get; set;}

		public CBuffImmunity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}