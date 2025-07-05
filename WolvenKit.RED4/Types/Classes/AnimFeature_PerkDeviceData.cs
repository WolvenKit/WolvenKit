using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_PerkDeviceData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isUsed")] 
		public CBool IsUsed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_PerkDeviceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
