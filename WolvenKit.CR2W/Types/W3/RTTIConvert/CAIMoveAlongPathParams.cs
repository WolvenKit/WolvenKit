using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMoveAlongPathParams : IAIActionParameters
	{
		[RED("pathTag")] 		public CName PathTag { get; set;}

		[RED("upThePath")] 		public CBool UpThePath { get; set;}

		[RED("fromBeginning")] 		public CBool FromBeginning { get; set;}

		[RED("pathMargin")] 		public CFloat PathMargin { get; set;}

		[RED("moveTypeBeforePath")] 		public CEnum<EMoveType> MoveTypeBeforePath { get; set;}

		[RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[RED("steeringGraph")] 		public CHandle<CMoveSteeringBehavior> SteeringGraph { get; set;}

		[RED("arrivalDistance")] 		public CFloat ArrivalDistance { get; set;}

		[RED("rotateAfterReachStart")] 		public CBool RotateAfterReachStart { get; set;}

		[RED("useExplorations")] 		public CBool UseExplorations { get; set;}

		[RED("dontCareAboutNavigable")] 		public CBool DontCareAboutNavigable { get; set;}

		[RED("tolerance")] 		public CFloat Tolerance { get; set;}

		public CAIMoveAlongPathParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMoveAlongPathParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}