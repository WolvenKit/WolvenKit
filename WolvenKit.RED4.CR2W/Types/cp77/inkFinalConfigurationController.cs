using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFinalConfigurationController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("visibilityFlag")] public CEnum<inkFinalConfigurationVisibility> VisibilityFlag { get; set; }

		public inkFinalConfigurationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
