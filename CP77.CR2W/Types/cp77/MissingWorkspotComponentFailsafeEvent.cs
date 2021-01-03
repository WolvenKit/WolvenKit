using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MissingWorkspotComponentFailsafeEvent : redEvent
	{
		[Ordinal(0)]  [RED("playerEntityID")] public entEntityID PlayerEntityID { get; set; }

		public MissingWorkspotComponentFailsafeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
