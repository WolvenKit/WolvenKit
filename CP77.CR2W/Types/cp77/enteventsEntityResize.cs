using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class enteventsEntityResize : redEvent
	{
		[Ordinal(0)]  [RED("extents")] public Vector3 Extents { get; set; }

		public enteventsEntityResize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
