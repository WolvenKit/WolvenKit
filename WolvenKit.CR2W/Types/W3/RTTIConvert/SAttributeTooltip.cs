using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAttributeTooltip : CVariable
	{
		[RED("originName")] 		public CName OriginName { get; set;}

		[RED("attributeName")] 		public CString AttributeName { get; set;}

		[RED("attributeColor")] 		public CString AttributeColor { get; set;}

		[RED("value")] 		public CFloat Value { get; set;}

		[RED("percentageValue")] 		public CBool PercentageValue { get; set;}

		[RED("primaryStat")] 		public CBool PrimaryStat { get; set;}

		public SAttributeTooltip(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAttributeTooltip(cr2w);

	}
}