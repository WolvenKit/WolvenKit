using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CacheFXOnDefeated : StatusEffectTasks
	{
		private wCHandle<NPCPuppet> _npcPuppet;

		[Ordinal(0)] 
		[RED("npcPuppet")] 
		public wCHandle<NPCPuppet> NpcPuppet
		{
			get => GetProperty(ref _npcPuppet);
			set => SetProperty(ref _npcPuppet, value);
		}

		public CacheFXOnDefeated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
