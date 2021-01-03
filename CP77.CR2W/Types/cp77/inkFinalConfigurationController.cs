using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkFinalConfigurationController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("visibilityFlag")] public CEnum<inkFinalConfigurationVisibility> VisibilityFlag { get; set; }

		public inkFinalConfigurationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
