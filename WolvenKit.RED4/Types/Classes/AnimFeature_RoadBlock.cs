using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_RoadBlock : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isOpening")] 
		public CBool IsOpening
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("initOpen")] 
		public CBool InitOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_RoadBlock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
