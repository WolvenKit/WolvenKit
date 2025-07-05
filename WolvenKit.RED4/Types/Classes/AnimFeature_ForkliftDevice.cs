using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_ForkliftDevice : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isUp")] 
		public CBool IsUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isDown")] 
		public CBool IsDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("distract")] 
		public CBool Distract
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_ForkliftDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
