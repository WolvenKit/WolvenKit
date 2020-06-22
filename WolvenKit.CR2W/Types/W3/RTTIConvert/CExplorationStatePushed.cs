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
		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("pushDirection")] 		public Vector PushDirection { get; set;}

		[RED("pushDirectionOther")] 		public Vector PushDirectionOther { get; set;}

		[RED("pushSide")] 		public CEnum<EPushSide> PushSide { get; set;}

		[RED("pushAngle")] 		public CFloat PushAngle { get; set;}

		[RED("extraTurnAngle")] 		public CFloat ExtraTurnAngle { get; set;}

		[RED("behCanEnd")] 		public CName BehCanEnd { get; set;}

		[RED("behSide")] 		public CName BehSide { get; set;}

		[RED("safetyEndTimeMax")] 		public CFloat SafetyEndTimeMax { get; set;}

		[RED("safetyEndTimeCur")] 		public CFloat SafetyEndTimeCur { get; set;}

		[RED("recheckTimeMin")] 		public CFloat RecheckTimeMin { get; set;}

		[RED("recheckTimeCur")] 		public CFloat RecheckTimeCur { get; set;}

		[RED("ticket")] 		public SMovementAdjustmentRequestTicket Ticket { get; set;}

		[RED("rotatedToCollider")] 		public CBool RotatedToCollider { get; set;}

		[RED("movedLeft")] 		public CBool MovedLeft { get; set;}

		public CExplorationStatePushed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStatePushed(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}