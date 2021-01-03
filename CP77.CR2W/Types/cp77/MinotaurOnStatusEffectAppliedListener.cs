using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MinotaurOnStatusEffectAppliedListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)]  [RED("minotaurMechComponent")] public CHandle<MinotaurMechComponent> MinotaurMechComponent { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }

		public MinotaurOnStatusEffectAppliedListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
