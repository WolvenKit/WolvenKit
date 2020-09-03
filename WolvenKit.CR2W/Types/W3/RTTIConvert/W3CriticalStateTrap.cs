using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CriticalStateTrap : CInteractiveEntity
	{
		[Ordinal(1)] [RED("effectOnSpawn")] 		public CName EffectOnSpawn { get; set;}

		[Ordinal(2)] [RED("effectToPlayOnActivation")] 		public CName EffectToPlayOnActivation { get; set;}

		[Ordinal(3)] [RED("durationFrom")] 		public CInt32 DurationFrom { get; set;}

		[Ordinal(4)] [RED("durationTo")] 		public CInt32 DurationTo { get; set;}

		[Ordinal(5)] [RED("areasActive")] 		public CBool AreasActive { get; set;}

		[Ordinal(6)] [RED("movementAdjustorActive")] 		public CBool MovementAdjustorActive { get; set;}

		[Ordinal(7)] [RED("params")] 		public SCustomEffectParams Params { get; set;}

		[Ordinal(8)] [RED("movementAdjustor")] 		public CHandle<CMovementAdjustor> MovementAdjustor { get; set;}

		[Ordinal(9)] [RED("ticket")] 		public SMovementAdjustmentRequestTicket Ticket { get; set;}

		[Ordinal(10)] [RED("ticketRot")] 		public SMovementAdjustmentRequestTicket TicketRot { get; set;}

		[Ordinal(11)] [RED("lifeTime")] 		public CInt32 LifeTime { get; set;}

		[Ordinal(12)] [RED("l_effectDuration")] 		public CInt32 L_effectDuration { get; set;}

		[Ordinal(13)] [RED("startTimestamp")] 		public CFloat StartTimestamp { get; set;}

		[Ordinal(14)] [RED("enterTimestamp")] 		public CFloat EnterTimestamp { get; set;}

		public W3CriticalStateTrap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CriticalStateTrap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}