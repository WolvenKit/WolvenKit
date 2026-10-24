using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_EquipType : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("firstEquip")] 
		public CBool FirstEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("dualWield")] 
		public CBool DualWield
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("equipDuration")] 
		public CFloat EquipDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("unequipDuration")] 
		public CFloat UnequipDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_EquipType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
