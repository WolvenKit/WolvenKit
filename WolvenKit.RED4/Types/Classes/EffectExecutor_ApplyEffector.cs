using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectExecutor_ApplyEffector : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("effector")] 
		public TweakDBID Effector
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public EffectExecutor_ApplyEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
