using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropPointRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("record")] public TweakDBID Record { get; set; }
		[Ordinal(1)]  [RED("status")] public CEnum<DropPointPackageStatus> Status { get; set; }
		[Ordinal(2)]  [RED("holder")] public gamePersistentID Holder { get; set; }

		public DropPointRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
