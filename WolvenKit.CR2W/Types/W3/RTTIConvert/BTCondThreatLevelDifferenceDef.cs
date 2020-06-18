using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondThreatLevelDifferenceDef : IBehTreeConditionalTaskDefinition
	{
		[RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[RED("value")] 		public CInt32 Value { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("useNamedTarget")] 		public CBehTreeValCName UseNamedTarget { get; set;}

		[RED("saveTargetOnGameplayEvent")] 		public CBehTreeValCName SaveTargetOnGameplayEvent { get; set;}

		public BTCondThreatLevelDifferenceDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTCondThreatLevelDifferenceDef(cr2w);

	}
}