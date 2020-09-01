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
		[Ordinal(0)] [RED("version")] 		public CUInt16 Version { get; set;}

		[Ordinal(0)] [RED("waypointsCount")] 		public CUInt16 WaypointsCount { get; set;}

		[Ordinal(0)] [RED("componentsMappingsCount")] 		public CUInt16 ComponentsMappingsCount { get; set;}

		[Ordinal(0)] [RED("waypointsGroupsCount")] 		public CUInt16 WaypointsGroupsCount { get; set;}

		[Ordinal(0)] [RED("indexesCount")] 		public CUInt32 IndexesCount { get; set;}

		[Ordinal(0)] [RED("parties", 2,0)] 		public CArray<SPartySpawner> Parties { get; set;}

		[Ordinal(0)] [RED("partyWaypoints", 2,0)] 		public CArray<SPartyWaypointData> PartyWaypoints { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWayPointsCollection(cr2w, parent, name);

	}
}