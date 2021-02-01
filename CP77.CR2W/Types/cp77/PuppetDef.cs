using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PuppetDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("ForceFriendlyCarry")] public gamebbScriptID_Bool ForceFriendlyCarry { get; set; }
		[Ordinal(1)]  [RED("ForcedCarryStyle")] public gamebbScriptID_Int32 ForcedCarryStyle { get; set; }
		[Ordinal(2)]  [RED("HasCPOMissionData")] public gamebbScriptID_Bool HasCPOMissionData { get; set; }
		[Ordinal(3)]  [RED("HideNameplate")] public gamebbScriptID_Bool HideNameplate { get; set; }
		[Ordinal(4)]  [RED("IsCrowd")] public gamebbScriptID_Bool IsCrowd { get; set; }

		public PuppetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
