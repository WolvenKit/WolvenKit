using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAbilityAttribute : CVariable
	{
		[Ordinal(0)] [RED("("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("("type")] 		public CEnum<EAbilityAttributeType> Type { get; set;}

		[Ordinal(0)] [RED("("alwaysRandom")] 		public CBool AlwaysRandom { get; set;}

		[Ordinal(0)] [RED("("min")] 		public CFloat Min { get; set;}

		[Ordinal(0)] [RED("("max")] 		public CFloat Max { get; set;}

		[Ordinal(0)] [RED("("precision")] 		public CInt8 Precision { get; set;}

		[Ordinal(0)] [RED("("displayPerc")] 		public CBool DisplayPerc { get; set;}

		public SAbilityAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAbilityAttribute(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}