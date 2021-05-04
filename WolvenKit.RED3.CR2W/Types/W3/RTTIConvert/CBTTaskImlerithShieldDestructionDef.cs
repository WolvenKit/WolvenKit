using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskImlerithShieldDestructionDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("firstTreshold")] 		public CFloat FirstTreshold { get; set;}

		[Ordinal(2)] [RED("secondTreshold")] 		public CFloat SecondTreshold { get; set;}

		[Ordinal(3)] [RED("thirdTreshold")] 		public CFloat ThirdTreshold { get; set;}

		[Ordinal(4)] [RED("finalTreshold")] 		public CFloat FinalTreshold { get; set;}

		[Ordinal(5)] [RED("dropShield")] 		public CBool DropShield { get; set;}

		public CBTTaskImlerithShieldDestructionDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}