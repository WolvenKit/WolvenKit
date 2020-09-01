using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_IsDLCEnabled : CQuestScriptedCondition
	{
		[Ordinal(0)] [RED("("dlc")] 		public CEnum<EQuestConditionDLCType> Dlc { get; set;}

		[Ordinal(0)] [RED("("invert")] 		public CBool Invert { get; set;}

		public W3QuestCond_IsDLCEnabled(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_IsDLCEnabled(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}