using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FollowNPCDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("Position")] public gamebbScriptID_Vector4 Position { get; set; }

		public FollowNPCDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
