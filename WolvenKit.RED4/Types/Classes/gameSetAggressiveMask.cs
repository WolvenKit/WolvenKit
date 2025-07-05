using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetAggressiveMask : redEvent
	{
		[Ordinal(0)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSetAggressiveMask()
		{
			IsAggressive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
