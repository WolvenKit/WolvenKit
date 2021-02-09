using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericCodexEntryData : IScriptable
	{
		[Ordinal(0)]  [RED("hash")] public CInt32 Hash { get; set; }
		[Ordinal(1)]  [RED("title")] public CString Title { get; set; }
		[Ordinal(2)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(3)]  [RED("imageId")] public TweakDBID ImageId { get; set; }
		[Ordinal(4)]  [RED("counter")] public CInt32 Counter { get; set; }
		[Ordinal(5)]  [RED("timeStamp")] public GameTime TimeStamp { get; set; }
		[Ordinal(6)]  [RED("isNew")] public CBool IsNew { get; set; }
		[Ordinal(7)]  [RED("newEntries")] public CArray<CInt32> NewEntries { get; set; }
		[Ordinal(8)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(9)]  [RED("activeDataSync")] public wCHandle<CodexListSyncData> ActiveDataSync { get; set; }

		public GenericCodexEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
