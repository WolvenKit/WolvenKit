using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStatePushed : CExplorationStateAbstract
	{
		[Ordinal(0)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("pushDirection")] 		public Vector PushDirection { get; set;}

		[Ordinal(0)] [RED("pushDirectionOther")] 		public Vector PushDirectionOther { get; set;}

		[Ordinal(0)] [RED("pushSide")] 		public CEnum<EPushSide> PushSide { get; set;}

		[Ordinal(0)] [RED("pushAngle")] 		public CFloat PushAngle { get; set;}

		[Ordinal(0)] [RED("extraTurnAngle")] 		public CFloat ExtraTurnAngle { get; set;}

		[Ordinal(0)] [RED("behCanEnd")] 		public CName BehCanEnd { get; set;}

		[Ordinal(0)] [RED("behSide")] 		public CName BehSide { get; set;}

		[Ordinal(0)] [RED("safetyEndTimeMax")] 		public CFloat SafetyEndTimeMax { get; set;}

		[Ordinal(0)] [RED("safetyEndTimeCur")] 		public CFloat SafetyEndTimeCur { get; set;}

		[Ordinal(0)] [RED("recheckTimeMin")] 		public CFloat RecheckTimeMin { get; set;}

		[Ordinal(0)] [RED("recheckTimeCur")] 		public CFloat RecheckTimeCur { get; set;}

		[Ordinal(0)] [RED("ticket")] 		public SMovementAdjustmentRequestTicket Ticket { get; set;}

		[Ordinal(0)] [RED("rotatedToCollider")] 		public CBool RotatedToCollider { get; set;}

		[Ordinal(0)] [RED("movedLeft")] 		public CBool MovedLeft { get; set;}

		public CExplorationStatePushed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStatePushed(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}