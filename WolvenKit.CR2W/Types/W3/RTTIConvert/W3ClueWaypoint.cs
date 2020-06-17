using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ClueWaypoint : CObject
	{
		[RED("waypointTag")] 		public CName WaypointTag { get; set;}

		[RED("clueStateInWaypoint")] 		public EBoidClueState ClueStateInWaypoint { get; set;}

		[RED("conditionsLogicalOperator")] 		public ELogicalOperator ConditionsLogicalOperator { get; set;}

		[RED("waypointReachedConditions", 2,0)] 		public CArray<CHandle<W3ClueCondition>> WaypointReachedConditions { get; set;}

		public W3ClueWaypoint(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ClueWaypoint(cr2w);

	}
}