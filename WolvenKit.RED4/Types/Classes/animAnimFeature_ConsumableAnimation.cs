using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_ConsumableAnimation : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("consumableType")] 
		public CInt32 ConsumableType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("useConsumable")] 
		public CBool UseConsumable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("animationScale")] 
		public CFloat AnimationScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimFeature_ConsumableAnimation()
		{
			AnimationScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
