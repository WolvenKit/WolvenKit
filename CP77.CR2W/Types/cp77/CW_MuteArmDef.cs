using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CW_MuteArmDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("MuteArmActive")] public gamebbScriptID_Bool MuteArmActive { get; set; }
		[Ordinal(1)]  [RED("MuteArmRadius")] public gamebbScriptID_Float MuteArmRadius { get; set; }

		public CW_MuteArmDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
