using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TvDeviceWidgetCustomData : WidgetCustomData
	{
		[Ordinal(0)] [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }
		[Ordinal(1)] [RED("channelID")] public TweakDBID ChannelID { get; set; }
		[Ordinal(2)] [RED("messageRecordID")] public TweakDBID MessageRecordID { get; set; }
		[Ordinal(3)] [RED("looped")] public CBool Looped { get; set; }

		public TvDeviceWidgetCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
