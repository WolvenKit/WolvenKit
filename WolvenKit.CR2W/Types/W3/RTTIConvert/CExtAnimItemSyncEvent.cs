using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimItemSyncEvent : CExtAnimEvent
	{
		[RED("equipSlot")] 		public CName EquipSlot { get; set;}

		[RED("holdSlot")] 		public CName HoldSlot { get; set;}

		[RED("action")] 		public CEnum<EItemLatentAction> Action { get; set;}

		public CExtAnimItemSyncEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimItemSyncEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}