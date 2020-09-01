using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMoveToWaypointDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("waypoint")] 		public CName Waypoint { get; set;}

		[Ordinal(0)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(0)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		public CBTTaskMoveToWaypointDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMoveToWaypointDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}