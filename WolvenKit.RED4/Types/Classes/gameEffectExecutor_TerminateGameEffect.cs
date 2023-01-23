using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_TerminateGameEffect : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("onlyWithPlayerInstigator")] 
		public CBool OnlyWithPlayerInstigator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectExecutor_TerminateGameEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
