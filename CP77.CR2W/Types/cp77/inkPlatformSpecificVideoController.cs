using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificVideoController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(1)]  [RED("video")] public raRef<Bink> Video { get; set; }
		[Ordinal(2)]  [RED("video_PS4")] public raRef<Bink> Video_PS4 { get; set; }
		[Ordinal(3)]  [RED("video_XB1")] public raRef<Bink> Video_XB1 { get; set; }

		public inkPlatformSpecificVideoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
