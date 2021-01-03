using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_EnableBumps : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)]  [RED("policy")] public CEnum<AIinfluenceEBumpPolicy> Policy { get; set; }
		[Ordinal(3)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questCharacterManagerParameters_EnableBumps(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
