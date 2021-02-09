using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhotoModeToggle : inkToggleController
	{
		[Ordinal(0)]  [RED("SelectedWidget")] public inkWidgetReference SelectedWidget { get; set; }
		[Ordinal(1)]  [RED("FrameWidget")] public inkWidgetReference FrameWidget { get; set; }
		[Ordinal(2)]  [RED("IconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(3)]  [RED("LabelWidget")] public inkTextWidgetReference LabelWidget { get; set; }
		[Ordinal(4)]  [RED("photoModeGroupController")] public wCHandle<PhotoModeTopBarController> PhotoModeGroupController { get; set; }
		[Ordinal(5)]  [RED("fadeAnim")] public CHandle<inkanimProxy> FadeAnim { get; set; }
		[Ordinal(6)]  [RED("fade2Anim")] public CHandle<inkanimProxy> Fade2Anim { get; set; }

		public PhotoModeToggle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
