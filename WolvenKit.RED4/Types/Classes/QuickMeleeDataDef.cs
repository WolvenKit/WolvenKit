using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickMeleeDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("NPCHit")] 
		public gamebbScriptID_Bool NPCHit
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public QuickMeleeDataDef()
		{
			NPCHit = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
