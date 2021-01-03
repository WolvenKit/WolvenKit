using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIStatListener : gameScriptStatsListener
	{
		[Ordinal(0)]  [RED("behaviorCallbackName")] public CName BehaviorCallbackName { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<ScriptedPuppet> Owner { get; set; }

		public AIStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
