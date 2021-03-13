using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetAttitudeGroupForPuppet : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)] [RED("groupName")] public CName GroupName { get; set; }

		public questCharacterManagerParameters_SetAttitudeGroupForPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
