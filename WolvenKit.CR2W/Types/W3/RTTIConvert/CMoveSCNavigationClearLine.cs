using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSCNavigationClearLine : IMoveSteeringCondition
	{
		[Ordinal(1)] [RED("destinationForward")] 		public CFloat DestinationForward { get; set;}

		[Ordinal(2)] [RED("destinationLeft")] 		public CFloat DestinationLeft { get; set;}

		[Ordinal(3)] [RED("testRadius")] 		public CFloat TestRadius { get; set;}

		[Ordinal(4)] [RED("useCharacterOrientation")] 		public CBool UseCharacterOrientation { get; set;}

		[Ordinal(5)] [RED("useSteeringOutput")] 		public CBool UseSteeringOutput { get; set;}

		[Ordinal(6)] [RED("useGoalDirection")] 		public CBool UseGoalDirection { get; set;}

		public CMoveSCNavigationClearLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSCNavigationClearLine(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}