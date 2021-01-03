using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class STvChannel : CVariable
	{
		[Ordinal(0)]  [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(1)]  [RED("channelName")] public CString ChannelName { get; set; }
		[Ordinal(2)]  [RED("channelTweakID")] public TweakDBID ChannelTweakID { get; set; }
		[Ordinal(3)]  [RED("looped")] public CBool Looped { get; set; }
		[Ordinal(4)]  [RED("messageRecordID")] public TweakDBID MessageRecordID { get; set; }
		[Ordinal(5)]  [RED("sequence")] public CArray<SequenceVideo> Sequence { get; set; }
		[Ordinal(6)]  [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }

		public STvChannel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
