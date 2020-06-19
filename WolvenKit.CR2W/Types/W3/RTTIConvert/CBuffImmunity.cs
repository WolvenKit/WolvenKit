using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBuffImmunity : CVariable
	{
		[RED("immunityTo", 2,0)] 		public CArray<CInt32> ImmunityTo { get; set;}

		[RED("potion")] 		public CBool Potion { get; set;}

		[RED("positive")] 		public CBool Positive { get; set;}

		[RED("negative")] 		public CBool Negative { get; set;}

		[RED("neutral")] 		public CBool Neutral { get; set;}

		[RED("immobilize")] 		public CBool Immobilize { get; set;}

		[RED("confuse")] 		public CBool Confuse { get; set;}

		[RED("damage")] 		public CBool Damage { get; set;}

		public CBuffImmunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBuffImmunity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}