using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class saveMetadata : saveGameMetadata
	{
		[Ordinal(41)] [RED("saveVersion")] public CUInt32 SaveVersion { get; set; }
		[Ordinal(42)] [RED("gameVersion")] public CUInt32 GameVersion { get; set; }
		[Ordinal(43)] [RED("timestampString")] public CString TimestampString { get; set; }
		[Ordinal(44)] [RED("name")] public CString Name { get; set; }
		[Ordinal(45)] [RED("userName")] public CString UserName { get; set; }
		[Ordinal(46)] [RED("buildID")] public CString BuildID { get; set; }
		[Ordinal(47)] [RED("platform")] public CString Platform { get; set; }
		[Ordinal(48)] [RED("censorFlags")] public CString CensorFlags { get; set; }
		[Ordinal(49)] [RED("buildConfiguration")] public CString BuildConfiguration { get; set; }
		[Ordinal(50)] [RED("fileSize")] public CUInt32 FileSize { get; set; }
		[Ordinal(51)] [RED("isForced")] public CBool IsForced { get; set; }
		[Ordinal(52)] [RED("isCheckpoint")] public CBool IsCheckpoint { get; set; }
		[Ordinal(53)] [RED("initialLoadingScreenID")] public CUInt64 InitialLoadingScreenID { get; set; }
		[Ordinal(54)] [RED("isStoryMode")] public CBool IsStoryMode { get; set; }
		[Ordinal(55)] [RED("isPointOfNoReturn")] public CBool IsPointOfNoReturn { get; set; }
		[Ordinal(56)] [RED("isEndGameSave")] public CBool IsEndGameSave { get; set; }

		public saveMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
