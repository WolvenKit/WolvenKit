using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PhotoModeDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("IsActive")] public gamebbScriptID_Bool IsActive { get; set; }
		[Ordinal(1)]  [RED("PlayerHealthState")] public gamebbScriptID_Uint32 PlayerHealthState { get; set; }

		public PhotoModeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
