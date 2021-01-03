using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceTakeControlDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("ActiveDevice")] public gamebbScriptID_EntityID ActiveDevice { get; set; }
		[Ordinal(1)]  [RED("ChainLocked")] public gamebbScriptID_Bool ChainLocked { get; set; }
		[Ordinal(2)]  [RED("DevicesChain")] public gamebbScriptID_Variant DevicesChain { get; set; }
		[Ordinal(3)]  [RED("IsDeviceWorking")] public gamebbScriptID_Bool IsDeviceWorking { get; set; }

		public DeviceTakeControlDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
