using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisableVisualOverride : redEvent
	{
		[Ordinal(0)] 
		[RED("blockReequipping")] 
		public CBool BlockReequipping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DisableVisualOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
