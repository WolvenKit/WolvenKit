using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVisualStateChangeEvent : redEvent
	{
		[Ordinal(0)] [RED("visualState")] public CName VisualState { get; set; }

		public inkVisualStateChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
