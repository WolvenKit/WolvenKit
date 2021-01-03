using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiUpdateInputHintEvent : redEvent
	{
		[Ordinal(0)]  [RED("data")] public gameuiInputHintData Data { get; set; }
		[Ordinal(1)]  [RED("show")] public CBool Show { get; set; }
		[Ordinal(2)]  [RED("targetHintContainer")] public CName TargetHintContainer { get; set; }

		public gameuiUpdateInputHintEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
