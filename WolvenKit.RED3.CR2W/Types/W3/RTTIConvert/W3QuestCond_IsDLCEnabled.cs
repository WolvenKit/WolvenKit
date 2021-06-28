using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_IsDLCEnabled : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("dlc")] 		public CEnum<EQuestConditionDLCType> Dlc { get; set;}

		[Ordinal(2)] [RED("invert")] 		public CBool Invert { get; set;}

		public W3QuestCond_IsDLCEnabled(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}