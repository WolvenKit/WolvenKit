using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameFastTravelPointData : IScriptable
	{
		[Ordinal(0)] [RED("pointRecord")] public TweakDBID PointRecord { get; set; }
		[Ordinal(1)] [RED("markerRef")] public NodeRef MarkerRef { get; set; }
		[Ordinal(2)] [RED("requesterID")] public entEntityID RequesterID { get; set; }
		[Ordinal(3)] [RED("mappinID")] public gameNewMappinID MappinID { get; set; }

		public gameFastTravelPointData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
