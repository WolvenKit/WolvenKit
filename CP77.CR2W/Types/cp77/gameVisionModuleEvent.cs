using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameVisionModuleEvent : redEvent
	{
		[Ordinal(0)]  [RED("activated")] public CBool Activated { get; set; }
		[Ordinal(1)]  [RED("activator")] public wCHandle<gameObject> Activator { get; set; }
		[Ordinal(2)]  [RED("changedModule")] public CName ChangedModule { get; set; }

		public gameVisionModuleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
