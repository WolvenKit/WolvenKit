using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerPerkDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Uint32 _woundedInstigated;
		private gamebbScriptID_Uint32 _dismembermentInstigated;
		private gamebbScriptID_Uint32 _entityNoticedPlayer;
		private gamebbScriptID_Float _combatStateTime;

		[Ordinal(0)] 
		[RED("WoundedInstigated")] 
		public gamebbScriptID_Uint32 WoundedInstigated
		{
			get => GetProperty(ref _woundedInstigated);
			set => SetProperty(ref _woundedInstigated, value);
		}

		[Ordinal(1)] 
		[RED("DismembermentInstigated")] 
		public gamebbScriptID_Uint32 DismembermentInstigated
		{
			get => GetProperty(ref _dismembermentInstigated);
			set => SetProperty(ref _dismembermentInstigated, value);
		}

		[Ordinal(2)] 
		[RED("EntityNoticedPlayer")] 
		public gamebbScriptID_Uint32 EntityNoticedPlayer
		{
			get => GetProperty(ref _entityNoticedPlayer);
			set => SetProperty(ref _entityNoticedPlayer, value);
		}

		[Ordinal(3)] 
		[RED("CombatStateTime")] 
		public gamebbScriptID_Float CombatStateTime
		{
			get => GetProperty(ref _combatStateTime);
			set => SetProperty(ref _combatStateTime, value);
		}

		public PlayerPerkDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
