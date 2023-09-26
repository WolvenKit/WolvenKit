using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocSelectorChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("Index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("SlidingRight")] 
		public CBool SlidingRight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RipperdocSelectorChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
