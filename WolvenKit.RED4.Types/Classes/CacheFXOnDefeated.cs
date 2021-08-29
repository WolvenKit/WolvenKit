using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CacheFXOnDefeated : StatusEffectTasks
	{
		private CWeakHandle<NPCPuppet> _npcPuppet;

		[Ordinal(0)] 
		[RED("npcPuppet")] 
		public CWeakHandle<NPCPuppet> NpcPuppet
		{
			get => GetProperty(ref _npcPuppet);
			set => SetProperty(ref _npcPuppet, value);
		}
	}
}
