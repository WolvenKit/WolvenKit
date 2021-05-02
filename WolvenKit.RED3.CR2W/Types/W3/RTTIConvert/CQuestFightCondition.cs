using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestFightCondition : IQuestCondition
	{
		[Ordinal(1)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(2)] [RED("attackerTag")] 		public CName AttackerTag { get; set;}

		[Ordinal(3)] [RED("referenceValue")] 		public CInt32 ReferenceValue { get; set;}

		[Ordinal(4)] [RED("damageMode")] 		public CEnum<EQueryFightMode> DamageMode { get; set;}

		public CQuestFightCondition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}