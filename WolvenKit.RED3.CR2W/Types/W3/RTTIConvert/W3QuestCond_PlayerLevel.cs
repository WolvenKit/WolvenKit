using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_PlayerLevel : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("level")] 		public CInt32 Level { get; set;}

		[Ordinal(2)] [RED("comparator")] 		public CEnum<ECompareOp> Comparator { get; set;}

		[Ordinal(3)] [RED("useComparator")] 		public CBool UseComparator { get; set;}

		[Ordinal(4)] [RED("returnValue")] 		public CBool ReturnValue { get; set;}

		public W3QuestCond_PlayerLevel(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}