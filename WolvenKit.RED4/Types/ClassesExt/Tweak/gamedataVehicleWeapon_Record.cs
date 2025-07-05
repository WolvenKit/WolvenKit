
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWeapon_Record
	{
		[RED("attackRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("canFriendlyFire")]
		[REDProperty(IsIgnored = true)]
		public CBool CanFriendlyFire
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("cycleTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat CycleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("genericShoot")]
		[REDProperty(IsIgnored = true)]
		public CBool GenericShoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("genericTick")]
		[REDProperty(IsIgnored = true)]
		public CBool GenericTick
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("item")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("maxPitch")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxYaw")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minPitch")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minYaw")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("singleProjectileCycleTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat SingleProjectileCycleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("singleShotProjectiles")]
		[REDProperty(IsIgnored = true)]
		public CInt32 SingleShotProjectiles
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("slot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Slot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("spread")]
		[REDProperty(IsIgnored = true)]
		public CFloat Spread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponShootAnimEvent")]
		[REDProperty(IsIgnored = true)]
		public CName WeaponShootAnimEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("wholeBurstProjectiles")]
		[REDProperty(IsIgnored = true)]
		public CInt32 WholeBurstProjectiles
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
