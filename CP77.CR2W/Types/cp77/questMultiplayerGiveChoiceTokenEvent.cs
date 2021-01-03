using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerGiveChoiceTokenEvent : redEvent
	{
		[Ordinal(0)]  [RED("compatibleDeviceName")] public CName CompatibleDeviceName { get; set; }
		[Ordinal(1)]  [RED("timeout")] public CUInt32 Timeout { get; set; }
		[Ordinal(2)]  [RED("tokenAlreadyGiven")] public CBool TokenAlreadyGiven { get; set; }

		public questMultiplayerGiveChoiceTokenEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
