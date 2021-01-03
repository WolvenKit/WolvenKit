using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecuritySupportListener : AIScriptsTargetTrackingListener
	{
		[Ordinal(0)]  [RED("npc")] public wCHandle<ScriptedPuppet> Npc { get; set; }

		public SecuritySupportListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
