using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerPerkDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("WoundedInstigated")] 
		public gamebbScriptID_Uint32 WoundedInstigated
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(1)] 
		[RED("DismembermentInstigated")] 
		public gamebbScriptID_Uint32 DismembermentInstigated
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(2)] 
		[RED("EntityNoticedPlayer")] 
		public gamebbScriptID_Uint32 EntityNoticedPlayer
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(3)] 
		[RED("CombatStateTime")] 
		public gamebbScriptID_Float CombatStateTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public PlayerPerkDataDef()
		{
			WoundedInstigated = new();
			DismembermentInstigated = new();
			EntityNoticedPlayer = new();
			CombatStateTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
