using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_LeftHandItem : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("itemInLeftHand")] 
		public CBool ItemInLeftHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimFeature_LeftHandItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
