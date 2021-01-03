using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class senseEnabledEvent : redEvent
	{
		[Ordinal(0)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public senseEnabledEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
