using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_BookHasBeenRead : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("("bookName")] 		public CName BookName { get; set;}

		[Ordinal(2)] [RED("("bookFactName")] 		public CString BookFactName { get; set;}

		[Ordinal(3)] [RED("("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(4)] [RED("("listener")] 		public CHandle<W3QuestCond_BookHasBeenRead_Listener> Listener { get; set;}

		public W3QuestCond_BookHasBeenRead(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_BookHasBeenRead(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}