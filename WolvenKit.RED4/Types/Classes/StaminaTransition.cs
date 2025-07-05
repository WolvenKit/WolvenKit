using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class StaminaTransition : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("staminaChangeToggle")] 
		public CBool StaminaChangeToggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public StaminaTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
