using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSetStyleEvent : inkanimEvent
	{
		[Ordinal(1)] [RED("style")] public raRef<inkStyleResource> Style { get; set; }

		public inkanimSetStyleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
