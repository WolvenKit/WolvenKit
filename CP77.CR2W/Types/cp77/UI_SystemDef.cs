using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_SystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("IsInMenu")] public gamebbScriptID_Bool IsInMenu { get; set; }
		[Ordinal(1)] [RED("CircularBlurEnabled")] public gamebbScriptID_Bool CircularBlurEnabled { get; set; }
		[Ordinal(2)] [RED("CircularBlurBlendTime")] public gamebbScriptID_Float CircularBlurBlendTime { get; set; }
		[Ordinal(3)] [RED("TrackedMappin")] public gamebbScriptID_Variant TrackedMappin { get; set; }

		public UI_SystemDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
