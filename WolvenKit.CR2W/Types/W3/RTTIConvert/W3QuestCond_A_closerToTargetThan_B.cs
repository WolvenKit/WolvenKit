using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_A_closerToTargetThan_B : CQuestScriptedCondition
	{
		[Ordinal(0)] [RED("("object_A_tag")] 		public CName Object_A_tag { get; set;}

		[Ordinal(0)] [RED("("object_B_tag")] 		public CName Object_B_tag { get; set;}

		[Ordinal(0)] [RED("("targetTag")] 		public CName TargetTag { get; set;}

		[Ordinal(0)] [RED("("listener")] 		public CHandle<W3QuestCond_A_closerToTargetThan_B_Listener> Listener { get; set;}

		[Ordinal(0)] [RED("("object_A")] 		public CHandle<CNode> Object_A { get; set;}

		[Ordinal(0)] [RED("("object_B")] 		public CHandle<CNode> Object_B { get; set;}

		[Ordinal(0)] [RED("("target")] 		public CHandle<CNode> Target { get; set;}

		public W3QuestCond_A_closerToTargetThan_B(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_A_closerToTargetThan_B(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}