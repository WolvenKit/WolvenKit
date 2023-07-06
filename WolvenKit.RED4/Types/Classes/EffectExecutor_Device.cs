using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class EffectExecutor_Device : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("maxDelay")] 
		public CFloat MaxDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public EffectExecutor_Device()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
