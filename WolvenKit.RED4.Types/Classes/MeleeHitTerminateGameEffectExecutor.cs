using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeHitTerminateGameEffectExecutor : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("ignoreWaterImpacts")] 
		public CBool IgnoreWaterImpacts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MeleeHitTerminateGameEffectExecutor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
