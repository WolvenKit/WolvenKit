using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioRadioTrack : CVariable
	{
		[Ordinal(0)]  [RED("isStreamingFriendly")] public CBool IsStreamingFriendly { get; set; }
		[Ordinal(1)]  [RED("localizationKey")] public CName LocalizationKey { get; set; }
		[Ordinal(2)]  [RED("primaryLocKey")] public CUInt64 PrimaryLocKey { get; set; }
		[Ordinal(3)]  [RED("trackEventName")] public CName TrackEventName { get; set; }

		public audioRadioTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
