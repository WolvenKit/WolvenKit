using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskImlerithShieldDestructionDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("firstTreshold")] 		public CFloat FirstTreshold { get; set;}

		[Ordinal(0)] [RED("secondTreshold")] 		public CFloat SecondTreshold { get; set;}

		[Ordinal(0)] [RED("thirdTreshold")] 		public CFloat ThirdTreshold { get; set;}

		[Ordinal(0)] [RED("finalTreshold")] 		public CFloat FinalTreshold { get; set;}

		[Ordinal(0)] [RED("dropShield")] 		public CBool DropShield { get; set;}

		public CBTTaskImlerithShieldDestructionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskImlerithShieldDestructionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}