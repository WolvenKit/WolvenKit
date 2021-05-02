using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_HasModifier : CQCActorScriptedCondition
	{
		[Ordinal(1)] [RED("modifier")] 		public CEnum<EEffectType> Modifier { get; set;}

		[Ordinal(2)] [RED("timePercents")] 		public CInt32 TimePercents { get; set;}

		[Ordinal(3)] [RED("condition")] 		public CEnum<ECompareOp> Condition { get; set;}

		[Ordinal(4)] [RED("modifierParam1")] 		public CName ModifierParam1 { get; set;}

		[Ordinal(5)] [RED("sourceName")] 		public CName SourceName { get; set;}

		[Ordinal(6)] [RED("sourceNamePartialSearch")] 		public CBool SourceNamePartialSearch { get; set;}

		public W3QuestCond_HasModifier(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}