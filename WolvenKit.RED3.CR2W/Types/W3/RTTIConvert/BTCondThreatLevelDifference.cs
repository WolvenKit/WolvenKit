using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondThreatLevelDifference : IBehTreeTask
	{
		[Ordinal(1)] [RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(2)] [RED("value")] 		public CInt32 Value { get; set;}

		[Ordinal(3)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(4)] [RED("useNamedTarget")] 		public CName UseNamedTarget { get; set;}

		[Ordinal(5)] [RED("saveTargetOnGameplayEvent")] 		public CName SaveTargetOnGameplayEvent { get; set;}

		[Ordinal(6)] [RED("m_Target")] 		public CHandle<CNode> M_Target { get; set;}

		public BTCondThreatLevelDifference(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondThreatLevelDifference(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}