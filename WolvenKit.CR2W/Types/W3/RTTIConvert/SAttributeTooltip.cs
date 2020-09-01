using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAttributeTooltip : CVariable
	{
		[Ordinal(0)] [RED("originName")] 		public CName OriginName { get; set;}

		[Ordinal(0)] [RED("attributeName")] 		public CString AttributeName { get; set;}

		[Ordinal(0)] [RED("attributeColor")] 		public CString AttributeColor { get; set;}

		[Ordinal(0)] [RED("value")] 		public CFloat Value { get; set;}

		[Ordinal(0)] [RED("percentageValue")] 		public CBool PercentageValue { get; set;}

		[Ordinal(0)] [RED("primaryStat")] 		public CBool PrimaryStat { get; set;}

		public SAttributeTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAttributeTooltip(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}