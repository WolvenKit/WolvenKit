using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskXMLBasedDurationDef : IBehTreeTaskDefinition
	{
		[RED("xmlStatName")] 		public CName XmlStatName { get; set;}

		[RED("chance")] 		public CInt32 Chance { get; set;}

		[RED("endWithFailure")] 		public CBool EndWithFailure { get; set;}

		public CBTTaskXMLBasedDurationDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskXMLBasedDurationDef(cr2w);

	}
}