using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_CheckBrazierPuzzleState : CQuestScriptedCondition
	{
		[Ordinal(0)] [RED("("lightList", 2,0)] 		public CArray<CName> LightList { get; set;}

		[Ordinal(0)] [RED("("lightsToTurnOn", 2,0)] 		public CArray<CInt32> LightsToTurnOn { get; set;}

		[Ordinal(0)] [RED("("componentList", 2,0)] 		public CArray<CHandle<CComponent>> ComponentList { get; set;}

		[Ordinal(0)] [RED("("expectedState", 2,0)] 		public CArray<CBool> ExpectedState { get; set;}

		[Ordinal(0)] [RED("("componentsFound")] 		public CBool ComponentsFound { get; set;}

		[Ordinal(0)] [RED("("statesDefined")] 		public CBool StatesDefined { get; set;}

		public W3QuestCond_CheckBrazierPuzzleState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_CheckBrazierPuzzleState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}