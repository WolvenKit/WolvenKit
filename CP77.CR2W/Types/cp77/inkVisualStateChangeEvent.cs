using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkVisualStateChangeEvent : redEvent
	{
		[Ordinal(0)]  [RED("visualState")] public CName VisualState { get; set; }

		public inkVisualStateChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
