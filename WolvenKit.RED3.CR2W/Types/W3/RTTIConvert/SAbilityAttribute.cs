using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAbilityAttribute : CVariable
	{
		[Ordinal(1)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(2)] [RED("type")] 		public CEnum<EAbilityAttributeType> Type { get; set;}

		[Ordinal(3)] [RED("alwaysRandom")] 		public CBool AlwaysRandom { get; set;}

		[Ordinal(4)] [RED("min")] 		public CFloat Min { get; set;}

		[Ordinal(5)] [RED("max")] 		public CFloat Max { get; set;}

		[Ordinal(6)] [RED("precision")] 		public CInt8 Precision { get; set;}

		[Ordinal(7)] [RED("displayPerc")] 		public CBool DisplayPerc { get; set;}

		public SAbilityAttribute(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}