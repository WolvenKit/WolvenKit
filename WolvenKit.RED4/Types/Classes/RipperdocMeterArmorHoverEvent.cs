using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocMeterArmorHoverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("IsHover")] 
		public CBool IsHover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("ArmorChange")] 
		public CFloat ArmorChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("ArmorMultiplier")] 
		public CFloat ArmorMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("CurrentArmorMultiplier")] 
		public CFloat CurrentArmorMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("EquippedArmorChange")] 
		public CFloat EquippedArmorChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("EquippedArmorMultiplier")] 
		public CFloat EquippedArmorMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("isCyberwareEquipped")] 
		public CBool IsCyberwareEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RipperdocMeterArmorHoverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
