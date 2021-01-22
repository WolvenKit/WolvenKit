using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class saveMetadata : saveGameMetadata
	{
		[Ordinal(0)]  [RED("buildConfiguration")] public CString BuildConfiguration { get; set; }
		[Ordinal(1)]  [RED("buildID")] public CString BuildID { get; set; }
		[Ordinal(2)]  [RED("censorFlags")] public CString CensorFlags { get; set; }
		[Ordinal(3)]  [RED("fileSize")] public CUInt32 FileSize { get; set; }
		[Ordinal(4)]  [RED("gameVersion")] public CUInt32 GameVersion { get; set; }
		[Ordinal(5)]  [RED("initialLoadingScreenID")] public CUInt64 InitialLoadingScreenID { get; set; }
		[Ordinal(6)]  [RED("isCheckpoint")] public CBool IsCheckpoint { get; set; }
		[Ordinal(7)]  [RED("isEndGameSave")] public CBool IsEndGameSave { get; set; }
		[Ordinal(8)]  [RED("isForced")] public CBool IsForced { get; set; }
		[Ordinal(9)]  [RED("isPointOfNoReturn")] public CBool IsPointOfNoReturn { get; set; }
		[Ordinal(10)]  [RED("isStoryMode")] public CBool IsStoryMode { get; set; }
		[Ordinal(11)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(12)]  [RED("platform")] public CString Platform { get; set; }
		[Ordinal(13)]  [RED("saveVersion")] public CUInt32 SaveVersion { get; set; }
		[Ordinal(14)]  [RED("timestampString")] public CString TimestampString { get; set; }
		[Ordinal(15)]  [RED("userName")] public CString UserName { get; set; }

		public saveMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
