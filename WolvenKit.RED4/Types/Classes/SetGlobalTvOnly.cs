using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetGlobalTvOnly : redEvent
	{
		[Ordinal(0)] 
		[RED("isGlobalTvOnly")] 
		public CBool IsGlobalTvOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetGlobalTvOnly()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
