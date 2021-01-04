using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerSecureAreaDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("inside")] public gamebbScriptID_Bool Inside { get; set; }

		public PlayerSecureAreaDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
