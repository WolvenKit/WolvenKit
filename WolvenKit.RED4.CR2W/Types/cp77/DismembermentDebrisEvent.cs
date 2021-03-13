using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentDebrisEvent : redEvent
	{
		[Ordinal(0)] [RED("resourcePath")] public CString ResourcePath { get; set; }
		[Ordinal(1)] [RED("strength")] public CFloat Strength { get; set; }

		public DismembermentDebrisEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
