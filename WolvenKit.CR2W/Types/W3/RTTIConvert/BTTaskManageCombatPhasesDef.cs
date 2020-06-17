using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageCombatPhasesDef : IBehTreeTaskDefinition
	{
		[RED("rangedCombatPhaseParameters")] 		public SCombatPhaseParameters RangedCombatPhaseParameters { get; set;}

		[RED("closeCombatPhaseParameters")] 		public SCombatPhaseParameters CloseCombatPhaseParameters { get; set;}

		[RED("nonCombatPhaseParameters")] 		public SCombatPhaseParameters NonCombatPhaseParameters { get; set;}

		[RED("setBehVariableName")] 		public CName SetBehVariableName { get; set;}

		public BTTaskManageCombatPhasesDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskManageCombatPhasesDef(cr2w);

	}
}