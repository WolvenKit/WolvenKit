using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entAnimInputSetterUsesSleepMode : redEvent
	{
		[Ordinal(0)]  [RED("value")] public CBool Value { get; set; }

		public entAnimInputSetterUsesSleepMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
