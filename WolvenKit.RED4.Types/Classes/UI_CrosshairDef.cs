using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_CrosshairDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _enemyNeutralized;

		[Ordinal(0)] 
		[RED("EnemyNeutralized")] 
		public gamebbScriptID_Variant EnemyNeutralized
		{
			get => GetProperty(ref _enemyNeutralized);
			set => SetProperty(ref _enemyNeutralized, value);
		}
	}
}
