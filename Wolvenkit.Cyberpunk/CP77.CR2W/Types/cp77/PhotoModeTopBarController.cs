using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhotoModeTopBarController : inkRadioGroupController
	{
		[Ordinal(0)]  [RED("photoModeTogglesArray")] public CArray<inkWidgetReference> PhotoModeTogglesArray { get; set; }

		public PhotoModeTopBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
