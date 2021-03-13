using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputProgressView : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("TargetImage")] public wCHandle<inkImageWidget> TargetImage { get; set; }
		[Ordinal(2)] [RED("ProgressPercent")] public CInt32 ProgressPercent { get; set; }
		[Ordinal(3)] [RED("PartName")] public CString PartName { get; set; }

		public InputProgressView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
