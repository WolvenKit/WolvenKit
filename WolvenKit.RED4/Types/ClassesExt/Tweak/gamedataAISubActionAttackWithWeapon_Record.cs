
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
		
		[RED("attackInitRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackInitRange
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
		
		[RED("attackWidth")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackWidth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("axisLowerMargin")]
		[REDProperty(IsIgnored = true)]
		public CFloat AxisLowerMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("axisUpperMargin")]
		[REDProperty(IsIgnored = true)]
		public CFloat AxisUpperMargin
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
		
		[RED("coneDirection")]
		[REDProperty(IsIgnored = true)]
		public Vector3 ConeDirection
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("coneHalfAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat ConeHalfAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("positionOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 PositionOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("stopContinuousAttackOnDurationEnd")]
		[REDProperty(IsIgnored = true)]
		public CBool StopContinuousAttackOnDurationEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
