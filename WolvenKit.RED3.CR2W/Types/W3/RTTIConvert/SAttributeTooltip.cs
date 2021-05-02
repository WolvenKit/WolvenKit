using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAttributeTooltip : CVariable
	{
		[Ordinal(1)] [RED("originName")] 		public CName OriginName { get; set;}

		[Ordinal(2)] [RED("attributeName")] 		public CString AttributeName { get; set;}

		[Ordinal(3)] [RED("attributeColor")] 		public CString AttributeColor { get; set;}

		[Ordinal(4)] [RED("value")] 		public CFloat Value { get; set;}

		[Ordinal(5)] [RED("percentageValue")] 		public CBool PercentageValue { get; set;}

		[Ordinal(6)] [RED("primaryStat")] 		public CBool PrimaryStat { get; set;}

		public SAttributeTooltip(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAttributeTooltip(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}