using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PartUninstallRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(2)] [RED("partID")] public gameItemID PartID { get; set; }

		public PartUninstallRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
