
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionAttackWithWeapon_Record
	{
		[RED("attack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Attack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("attackDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attackName")]
		[REDProperty(IsIgnored = true)]
		public CName AttackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("attackRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attackTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("colliderBoxSize")]
		[REDProperty(IsIgnored = true)]
		public Vector3 ColliderBoxSize
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("weaponSlots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> WeaponSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
