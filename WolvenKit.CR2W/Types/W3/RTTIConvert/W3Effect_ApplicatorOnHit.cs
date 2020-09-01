using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_ApplicatorOnHit : W3ApplicatorEffect
	{
		[Ordinal(0)] [RED("("fromSilverSword")] 		public CBool FromSilverSword { get; set;}

		[Ordinal(0)] [RED("("fromSteelSword")] 		public CBool FromSteelSword { get; set;}

		[Ordinal(0)] [RED("("fromSign")] 		public CBool FromSign { get; set;}

		[Ordinal(0)] [RED("("fromAll")] 		public CBool FromAll { get; set;}

		public W3Effect_ApplicatorOnHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_ApplicatorOnHit(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}