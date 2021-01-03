using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DisableRPGRequirementsForDeviceActions : redEvent
	{
		[Ordinal(0)]  [RED("action")] public TweakDBID Action { get; set; }
		[Ordinal(1)]  [RED("disable")] public CBool Disable { get; set; }

		public DisableRPGRequirementsForDeviceActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
