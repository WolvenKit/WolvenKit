using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponAnimFeature_WeaponData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("chargePercentage")] 
		public CFloat ChargePercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("timeInMaxCharge")] 
		public CFloat TimeInMaxCharge
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("ammoRemaining")] 
		public CInt32 AmmoRemaining
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("triggerMode")] 
		public CInt32 TriggerMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("isMagazineFull")] 
		public CBool IsMagazineFull
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isTriggerDown")] 
		public CBool IsTriggerDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameweaponAnimFeature_WeaponData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
