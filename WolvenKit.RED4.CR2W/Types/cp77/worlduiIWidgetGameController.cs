using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worlduiIWidgetGameController : inkIWidgetController
	{
		[Ordinal(1)] [RED("elementRecordID")] public TweakDBID ElementRecordID { get; set; }

		public worlduiIWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
