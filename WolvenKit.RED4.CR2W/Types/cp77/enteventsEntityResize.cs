using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsEntityResize : redEvent
	{
		[Ordinal(0)] [RED("extents")] public Vector3 Extents { get; set; }

		public enteventsEntityResize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
