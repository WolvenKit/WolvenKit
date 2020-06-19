using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_WasMeditating : CQuestScriptedCondition
	{
		[RED("hours")] 		public CInt32 Hours { get; set;}

		[RED("comparator")] 		public CEnum<ECompareOp> Comparator { get; set;}

		[RED("dayPart")] 		public CEnum<EDayPart> DayPart { get; set;}

		[RED("meditateToHour")] 		public CBool MeditateToHour { get; set;}

		[RED("immediateTest")] 		public CBool ImmediateTest { get; set;}

		public W3QuestCond_WasMeditating(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_WasMeditating(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}