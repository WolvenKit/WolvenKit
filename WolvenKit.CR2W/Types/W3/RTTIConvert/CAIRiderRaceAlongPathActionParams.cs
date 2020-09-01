using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIRiderRaceAlongPathActionParams : IRiderActionParameters
	{
		[Ordinal(1)] [RED("("pathTag")] 		public CName PathTag { get; set;}

		[Ordinal(2)] [RED("("upThePath")] 		public CBool UpThePath { get; set;}

		[Ordinal(3)] [RED("("fromBeginning")] 		public CBool FromBeginning { get; set;}

		[Ordinal(4)] [RED("("pathMargin")] 		public CFloat PathMargin { get; set;}

		[Ordinal(5)] [RED("("tolerance")] 		public CFloat Tolerance { get; set;}

		[Ordinal(6)] [RED("("moveTypeBeforePath")] 		public CEnum<EMoveType> MoveTypeBeforePath { get; set;}

		[Ordinal(7)] [RED("("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(8)] [RED("("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(9)] [RED("("steeringGraph")] 		public CHandle<CMoveSteeringBehavior> SteeringGraph { get; set;}

		[Ordinal(10)] [RED("("arrivalDistance")] 		public CFloat ArrivalDistance { get; set;}

		[Ordinal(11)] [RED("("rotateAfterReachStart")] 		public CBool RotateAfterReachStart { get; set;}

		[Ordinal(12)] [RED("("dontCareAboutNavigable")] 		public CBool DontCareAboutNavigable { get; set;}

		public CAIRiderRaceAlongPathActionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIRiderRaceAlongPathActionParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}