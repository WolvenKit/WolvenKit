using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BlackwallAnimDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("deathAnimNumber")] 
		public gamebbScriptID_Int32 DeathAnimNumber
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("handGestureAnimNumber")] 
		public gamebbScriptID_Int32 HandGestureAnimNumber
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public BlackwallAnimDef()
		{
			DeathAnimNumber = new gamebbScriptID_Int32();
			HandGestureAnimNumber = new gamebbScriptID_Int32();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
