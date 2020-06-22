using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_EntityComponentExists : CQuestScriptedCondition
	{
		[RED("tag")] 		public CName Tag { get; set;}

		[RED("componentName")] 		public CName ComponentName { get; set;}

		[RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[RED("component")] 		public CHandle<CComponent> Component { get; set;}

		[RED("listener")] 		public CHandle<W3QuestCond_EntityComponentExists_Listener> Listener { get; set;}

		public W3QuestCond_EntityComponentExists(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_EntityComponentExists(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}