using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_MeleeAttack : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("hit")] 
		public CBool Hit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_MeleeAttack()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
