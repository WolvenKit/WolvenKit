using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_CheckLightState : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("lightSourceTag")] 		public CName LightSourceTag { get; set;}

		[Ordinal(2)] [RED("targetState")] 		public CBool TargetState { get; set;}

		[Ordinal(3)] [RED("lightEntity")] 		public CHandle<CEntity> LightEntity { get; set;}

		[Ordinal(4)] [RED("component")] 		public CHandle<CGameplayLightComponent> Component { get; set;}

		[Ordinal(5)] [RED("listener")] 		public CHandle<W3QuestCond_CheckLightState_Listener> Listener { get; set;}

		public W3QuestCond_CheckLightState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_CheckLightState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}