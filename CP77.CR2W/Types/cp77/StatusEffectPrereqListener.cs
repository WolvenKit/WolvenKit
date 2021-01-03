using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPrereqListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)]  [RED("state")] public wCHandle<StatusEffectPrereqState> State { get; set; }

		public StatusEffectPrereqListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
