using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPuppetsUnconscious : questPuppetsEffector
	{
		[Ordinal(0)] 
		[RED("setUnconscious")] 
		public CBool SetUnconscious
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questPuppetsUnconscious()
		{
			SetUnconscious = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
