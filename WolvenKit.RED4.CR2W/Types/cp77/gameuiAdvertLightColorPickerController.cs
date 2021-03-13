using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAdvertLightColorPickerController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("lightColor")] public CColor LightColor { get; set; }

		public gameuiAdvertLightColorPickerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
