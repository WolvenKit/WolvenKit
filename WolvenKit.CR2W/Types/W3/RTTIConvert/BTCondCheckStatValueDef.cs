using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondCheckStatValueDef : IBehTreeConditionalTaskDefinition
	{
		[RED("checkedActor")] 		public CEnum<EStatOwner> CheckedActor { get; set;}

		[RED("baseStatType")] 		public CEnum<EBaseCharacterStats> BaseStatType { get; set;}

		[RED("autoCheckHPType")] 		public CBool AutoCheckHPType { get; set;}

		[RED("statValue")] 		public CFloat StatValue { get; set;}

		[RED("percentage")] 		public CBool Percentage { get; set;}

		[RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		public BTCondCheckStatValueDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTCondCheckStatValueDef(cr2w);

	}
}