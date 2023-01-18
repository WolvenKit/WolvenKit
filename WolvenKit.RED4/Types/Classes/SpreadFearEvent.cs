using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpreadFearEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CBool Player
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CInt32 Phase
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SpreadFearEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
