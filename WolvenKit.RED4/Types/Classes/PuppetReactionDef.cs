using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PuppetReactionDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("exitReactionFlag")] 
		public gamebbScriptID_Bool ExitReactionFlag
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("blockReactionFlag")] 
		public gamebbScriptID_Bool BlockReactionFlag
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public PuppetReactionDef()
		{
			ExitReactionFlag = new();
			BlockReactionFlag = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
