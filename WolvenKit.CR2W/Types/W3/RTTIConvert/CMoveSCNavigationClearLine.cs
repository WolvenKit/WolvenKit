using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSCNavigationClearLine : IMoveSteeringCondition
	{
		[RED("destinationForward")] 		public CFloat DestinationForward { get; set;}

		[RED("destinationLeft")] 		public CFloat DestinationLeft { get; set;}

		[RED("testRadius")] 		public CFloat TestRadius { get; set;}

		[RED("useCharacterOrientation")] 		public CBool UseCharacterOrientation { get; set;}

		[RED("useSteeringOutput")] 		public CBool UseSteeringOutput { get; set;}

		[RED("useGoalDirection")] 		public CBool UseGoalDirection { get; set;}

		public CMoveSCNavigationClearLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSCNavigationClearLine(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}