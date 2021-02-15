using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class STvChannel : CVariable
	{
		[Ordinal(0)] [RED("channelName")] public CString ChannelName { get; set; }
		[Ordinal(1)] [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }
		[Ordinal(2)] [RED("messageRecordID")] public TweakDBID MessageRecordID { get; set; }
		[Ordinal(3)] [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(4)] [RED("looped")] public CBool Looped { get; set; }
		[Ordinal(5)] [RED("sequence")] public CArray<SequenceVideo> Sequence { get; set; }
		[Ordinal(6)] [RED("channelTweakID")] public TweakDBID ChannelTweakID { get; set; }

		public STvChannel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
