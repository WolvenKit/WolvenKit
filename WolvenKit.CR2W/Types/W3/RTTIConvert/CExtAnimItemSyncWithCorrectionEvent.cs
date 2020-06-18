using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimItemSyncWithCorrectionEvent : CExtAnimDurationEvent
	{
		[RED("equipSlot")] 		public CName EquipSlot { get; set;}

		[RED("holdSlot")] 		public CName HoldSlot { get; set;}

		[RED("action")] 		public CEnum<EItemLatentAction> Action { get; set;}

		[RED("correctionBone")] 		public CName CorrectionBone { get; set;}

		public CExtAnimItemSyncWithCorrectionEvent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExtAnimItemSyncWithCorrectionEvent(cr2w);

	}
}