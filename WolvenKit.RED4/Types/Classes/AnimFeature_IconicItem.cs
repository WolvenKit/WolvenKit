using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_IconicItem : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isFreeDrilling")] 
		public CBool IsFreeDrilling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isActiveDrilling")] 
		public CBool IsActiveDrilling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isScanToInteraction")] 
		public CBool IsScanToInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isItemEquipped")] 
		public CBool IsItemEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_IconicItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
