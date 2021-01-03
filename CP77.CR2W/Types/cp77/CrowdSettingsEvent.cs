using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CrowdSettingsEvent : redEvent
	{
		[Ordinal(0)]  [RED("movementType")] public CName MovementType { get; set; }
		[Ordinal(1)]  [RED("resetFear")] public CBool ResetFear { get; set; }

		public CrowdSettingsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
