using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerSecureAreaDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("inside")] public gamebbScriptID_Bool Inside { get; set; }

		public PlayerSecureAreaDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
