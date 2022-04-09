using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeaturePlaySlotAnim : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("blendInTime")] 
		public CFloat BlendInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("speedMultiplier")] 
		public CFloat SpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("startOffsetRelative")] 
		public CFloat StartOffsetRelative
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("playAsAdditive")] 
		public CBool PlayAsAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("enableMotion")] 
		public CBool EnableMotion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("numberOfLoops")] 
		public CInt32 NumberOfLoops
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimFeaturePlaySlotAnim()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
