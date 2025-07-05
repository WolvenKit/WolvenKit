using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EFirstEquipData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("weaponID")] 
		public TweakDBID WeaponID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("hasPlayedFirstEquip")] 
		public CBool HasPlayedFirstEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EFirstEquipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
