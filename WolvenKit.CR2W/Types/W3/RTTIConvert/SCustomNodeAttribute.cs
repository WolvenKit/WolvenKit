using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCustomNodeAttribute : CVariable
	{
		[RED("attributeName")] 		public CName AttributeName { get; set;}

		[RED("attributeValue")] 		public CString AttributeValue { get; set;}

		[RED("attributeValueAsCName")] 		public CName AttributeValueAsCName { get; set;}

		public SCustomNodeAttribute(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SCustomNodeAttribute(cr2w);

	}
}