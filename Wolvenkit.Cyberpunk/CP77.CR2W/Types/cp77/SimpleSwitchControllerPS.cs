using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SimpleSwitchControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("nameForOFF")] public TweakDBID NameForOFF { get; set; }
		[Ordinal(1)]  [RED("nameForON")] public TweakDBID NameForON { get; set; }
		[Ordinal(2)]  [RED("switchAction")] public CEnum<ESwitchAction> SwitchAction { get; set; }

		public SimpleSwitchControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
