using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetCustomPersonalLinkReason : ScriptableDeviceAction
	{
		[Ordinal(0)]  [RED("reason")] public TweakDBID Reason { get; set; }

		public SetCustomPersonalLinkReason(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
