using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCDeathListener : gameScriptStatPoolsListener
	{
		private wCHandle<NPCPuppet> _npc;

		[Ordinal(0)] 
		[RED("npc")] 
		public wCHandle<NPCPuppet> Npc
		{
			get => GetProperty(ref _npc);
			set => SetProperty(ref _npc, value);
		}

		public NPCDeathListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
