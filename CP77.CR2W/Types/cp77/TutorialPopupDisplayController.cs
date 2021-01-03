using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TutorialPopupDisplayController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(1)]  [RED("inputHint")] public inkWidgetReference InputHint { get; set; }
		[Ordinal(2)]  [RED("message")] public inkTextWidgetReference Message { get; set; }
		[Ordinal(3)]  [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(4)]  [RED("video_1024x576")] public inkVideoWidgetReference Video_1024x576 { get; set; }
		[Ordinal(5)]  [RED("video_1280x720")] public inkVideoWidgetReference Video_1280x720 { get; set; }
		[Ordinal(6)]  [RED("video_1360x768")] public inkVideoWidgetReference Video_1360x768 { get; set; }
		[Ordinal(7)]  [RED("video_720x405")] public inkVideoWidgetReference Video_720x405 { get; set; }

		public TutorialPopupDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
