using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_CrosshairDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("EnemyNeutralized")] 
		public gamebbScriptID_Variant EnemyNeutralized
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_CrosshairDef()
		{
			EnemyNeutralized = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
