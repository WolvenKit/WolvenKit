using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worlduiIWidgetGameController : inkIWidgetController
	{
		[Ordinal(0)]  [RED("elementRecordID")] public TweakDBID ElementRecordID { get; set; }

		public worlduiIWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
