using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocMeterCapacityHoverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("IsHover")] 
		public CBool IsHover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("CapacityChange")] 
		public CInt32 CapacityChange
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("isCyberwareEquipped")] 
		public CBool IsCyberwareEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RipperdocMeterCapacityHoverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
