using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entContextualLookAtAddEvent : entLookAtAddEvent
	{
		[Ordinal(0)]  [RED("contextName")] public CName ContextName { get; set; }

		public entContextualLookAtAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
