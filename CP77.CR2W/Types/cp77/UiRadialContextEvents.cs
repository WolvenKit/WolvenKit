using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UiRadialContextEvents : InputContextTransitionEvents
	{
		[Ordinal(0)]  [RED("mouse")] public Vector4 Mouse { get; set; }

		public UiRadialContextEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
