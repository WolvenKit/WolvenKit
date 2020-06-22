using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CWayPointsCollection : CResource
	{
		[RED("version")] 		public CUInt16 Version { get; set;}

		[RED("waypointsCount")] 		public CUInt16 WaypointsCount { get; set;}

		[RED("componentsMappingsCount")] 		public CUInt16 ComponentsMappingsCount { get; set;}

		[RED("waypointsGroupsCount")] 		public CUInt16 WaypointsGroupsCount { get; set;}

		[RED("indexesCount")] 		public CUInt32 IndexesCount { get; set;}

		[RED("parties", 2,0)] 		public CArray<SPartySpawner> Parties { get; set;}

		[RED("partyWaypoints", 2,0)] 		public CArray<SPartyWaypointData> PartyWaypoints { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWayPointsCollection(cr2w, parent, name);

	}
}