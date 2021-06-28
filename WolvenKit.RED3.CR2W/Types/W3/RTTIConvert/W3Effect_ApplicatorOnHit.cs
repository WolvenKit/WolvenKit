using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_ApplicatorOnHit : W3ApplicatorEffect
	{
		[Ordinal(1)] [RED("fromSilverSword")] 		public CBool FromSilverSword { get; set;}

		[Ordinal(2)] [RED("fromSteelSword")] 		public CBool FromSteelSword { get; set;}

		[Ordinal(3)] [RED("fromSign")] 		public CBool FromSign { get; set;}

		[Ordinal(4)] [RED("fromAll")] 		public CBool FromAll { get; set;}

		public W3Effect_ApplicatorOnHit(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}