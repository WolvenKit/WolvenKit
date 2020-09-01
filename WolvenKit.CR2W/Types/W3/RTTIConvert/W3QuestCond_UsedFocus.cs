using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_UsedFocus : CQuestScriptedCondition
	{
		[Ordinal(0)] [RED("("inverted")] 		public CBool Inverted { get; set;}

		[Ordinal(0)] [RED("("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(0)] [RED("("timeStart")] 		public CFloat TimeStart { get; set;}

		public W3QuestCond_UsedFocus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_UsedFocus(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}