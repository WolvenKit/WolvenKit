using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleController : inkToggleController
	{
		[Ordinal(13)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(14)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(15)] [RED("data")] public CInt32 Data { get; set; }

		public ToggleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
