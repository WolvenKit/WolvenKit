using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ProgressBarsController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("mask")] public inkWidgetReference Mask { get; set; }

		public ProgressBarsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
