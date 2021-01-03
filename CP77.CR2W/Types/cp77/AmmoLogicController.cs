using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AmmoLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("capacity")] public CUInt32 Capacity { get; set; }
		[Ordinal(1)]  [RED("count")] public CUInt32 Count { get; set; }

		public AmmoLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
