using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_DistractionState : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_DistractionState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
