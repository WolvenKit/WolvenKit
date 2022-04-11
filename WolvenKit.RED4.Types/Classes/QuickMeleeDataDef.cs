using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			NPCHit = new();
		}
	}
}
