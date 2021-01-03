using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TvDeviceWidgetCustomData : WidgetCustomData
	{
		[Ordinal(0)]  [RED("channelID")] public TweakDBID ChannelID { get; set; }
		[Ordinal(1)]  [RED("looped")] public CBool Looped { get; set; }
		[Ordinal(2)]  [RED("messageRecordID")] public TweakDBID MessageRecordID { get; set; }
		[Ordinal(3)]  [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }

		public TvDeviceWidgetCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
