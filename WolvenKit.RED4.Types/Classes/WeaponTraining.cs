using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponTraining : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("rewardRecord")] 
		public TweakDBID RewardRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(95)] 
		[RED("weaponTypes")] 
		public CArray<CEnum<gamedataItemType>> WeaponTypes
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(96)] 
		[RED("limitOfHits")] 
		public CInt32 LimitOfHits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(97)] 
		[RED("amountOfHits")] 
		public CInt32 AmountOfHits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public WeaponTraining()
		{
			ControllerTypeName = "WeaponTrainingController";
			WeaponTypes = new();
			LimitOfHits = 30;
		}
	}
}
