using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_HasModifier : CQCActorScriptedCondition
	{
		[RED("modifier")] 		public CEnum<EEffectType> Modifier { get; set;}

		[RED("timePercents")] 		public CInt32 TimePercents { get; set;}

		[RED("condition")] 		public CEnum<ECompareOp> Condition { get; set;}

		[RED("modifierParam1")] 		public CName ModifierParam1 { get; set;}

		[RED("sourceName")] 		public CName SourceName { get; set;}

		[RED("sourceNamePartialSearch")] 		public CBool SourceNamePartialSearch { get; set;}

		public W3QuestCond_HasModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_HasModifier(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}