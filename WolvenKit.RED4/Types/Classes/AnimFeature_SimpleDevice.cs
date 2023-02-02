using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_SimpleDevice : animAnimFeatureMarkUnstable
	{
		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isOpenLeft")] 
		public CBool IsOpenLeft
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isOpenRight")] 
		public CBool IsOpenRight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_SimpleDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
