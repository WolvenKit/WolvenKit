using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_Container : CQuestScriptedCondition
	{
		[RED("containerTag")] 		public CName ContainerTag { get; set;}

		[RED("contents")] 		public CEnum<EContainerMode> Contents { get; set;}

		[RED("inventory")] 		public CHandle<CInventoryComponent> Inventory { get; set;}

		[RED("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[RED("globalListener")] 		public CHandle<W3QuestCond_Container_GlobalListener> GlobalListener { get; set;}

		[RED("inventoryListener")] 		public CHandle<W3QuestCond_Container_InventoryListener> InventoryListener { get; set;}

		public W3QuestCond_Container(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_Container(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}