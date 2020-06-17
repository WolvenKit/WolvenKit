using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondBaseStatLowerThanDef : IBehTreeConditionalTaskDefinition
	{
		[RED("checkedActor")] 		public EStatOwner CheckedActor { get; set;}

		[RED("baseStatType")] 		public EBaseCharacterStats BaseStatType { get; set;}

		[RED("statValue")] 		public CFloat StatValue { get; set;}

		[RED("percentage")] 		public CBool Percentage { get; set;}

		[RED("ifNot")] 		public CBool IfNot { get; set;}

		public BTCondBaseStatLowerThanDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTCondBaseStatLowerThanDef(cr2w);

	}
}