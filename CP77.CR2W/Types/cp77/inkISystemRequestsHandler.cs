using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkISystemRequestsHandler : IScriptable
	{
		[Ordinal(0)]  [RED("SaveDeleted")] public inkDeleteRequestResult SaveDeleted { get; set; }
		[Ordinal(1)]  [RED("SaveMetadataReady")] public inkSaveMetadataRequestResult SaveMetadataReady { get; set; }
		[Ordinal(2)]  [RED("SavesReady")] public inkSystemRequesResult SavesReady { get; set; }
		[Ordinal(3)]  [RED("ServersSearchResult")] public inkSystemServerRequesResult ServersSearchResult { get; set; }
		[Ordinal(4)]  [RED("UserChanged")] public inkUserIdResult UserChanged { get; set; }
		[Ordinal(5)]  [RED("UserIdResult")] public inkUserIdResult UserIdResult { get; set; }

		public inkISystemRequestsHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
