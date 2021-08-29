using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCDeathListener : gameScriptStatPoolsListener
	{
		private CWeakHandle<NPCPuppet> _npc;

		[Ordinal(0)] 
		[RED("npc")] 
		public CWeakHandle<NPCPuppet> Npc
		{
			get => GetProperty(ref _npc);
			set => SetProperty(ref _npc, value);
		}
	}
}
