using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PhotoModeTopBarController : inkRadioGroupController
	{
		[Ordinal(0)]  [RED("photoModeTogglesArray")] public CArray<inkWidgetReference> PhotoModeTogglesArray { get; set; }

		public PhotoModeTopBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
