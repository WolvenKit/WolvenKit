using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMoveToWaypoint : IBehTreeTask
	{
		[Ordinal(1)] [RED("waypoint")] 		public CName Waypoint { get; set;}

		[Ordinal(2)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(3)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(4)] [RED("isMoving")] 		public CBool IsMoving { get; set;}

		[Ordinal(5)] [RED("gotTarget")] 		public CBool GotTarget { get; set;}

		public CBTTaskMoveToWaypoint(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}