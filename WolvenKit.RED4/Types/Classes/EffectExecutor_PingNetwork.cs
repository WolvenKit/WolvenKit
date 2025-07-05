using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectExecutor_PingNetwork : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		public EffectExecutor_PingNetwork()
		{
			FxResource = new gameFxResource();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
