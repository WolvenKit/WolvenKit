using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_BulletBend : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("animProgression")] 
		public CFloat AnimProgression
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("randomAdditive")] 
		public CFloat RandomAdditive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("isResetting")] 
		public CBool IsResetting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_BulletBend()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
