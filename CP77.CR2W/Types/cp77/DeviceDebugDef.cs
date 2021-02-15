using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceDebugDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("CurrentlyDebuggedDevice")] public gamebbScriptID_CName CurrentlyDebuggedDevice { get; set; }
		[Ordinal(1)] [RED("DebuggedEntityIDAsString")] public gamebbScriptID_String DebuggedEntityIDAsString { get; set; }

		public DeviceDebugDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
