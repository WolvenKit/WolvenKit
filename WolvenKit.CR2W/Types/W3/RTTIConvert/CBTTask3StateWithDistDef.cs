using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateWithDistDef : CBTTask3StateAttackDef
	{
		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("endLess")] 		public EAttackType EndLess { get; set;}

		[RED("endMore")] 		public EAttackType EndMore { get; set;}

		public CBTTask3StateWithDistDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTask3StateWithDistDef(cr2w);

	}
}