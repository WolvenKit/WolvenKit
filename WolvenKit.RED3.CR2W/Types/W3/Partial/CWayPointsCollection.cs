using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CWayPointsCollection : CResource
	{
		[Ordinal(1)] [RED("version")] 		public CUInt16 Version { get; set;}

		[Ordinal(2)] [RED("waypointsCount")] 		public CUInt16 WaypointsCount { get; set;}

		[Ordinal(3)] [RED("componentsMappingsCount")] 		public CUInt16 ComponentsMappingsCount { get; set;}

		[Ordinal(4)] [RED("waypointsGroupsCount")] 		public CUInt16 WaypointsGroupsCount { get; set;}

		[Ordinal(5)] [RED("indexesCount")] 		public CUInt32 IndexesCount { get; set;}

		[Ordinal(6)] [RED("parties", 2,0)] 		public CArray<SPartySpawner> Parties { get; set;}

		[Ordinal(7)] [RED("partyWaypoints", 2,0)] 		public CArray<SPartyWaypointData> PartyWaypoints { get; set;}


	}
}
