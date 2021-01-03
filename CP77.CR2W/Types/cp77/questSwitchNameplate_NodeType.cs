using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSwitchNameplate_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("alternativeName")] public CBool AlternativeName { get; set; }
		[Ordinal(1)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(2)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questSwitchNameplate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
