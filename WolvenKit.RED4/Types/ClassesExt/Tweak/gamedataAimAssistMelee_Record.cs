
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAimAssistMelee_Record
	{
		[RED("aimSnapOnAim")]
		[REDProperty(IsIgnored = true)]
		public CBool AimSnapOnAim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("aimSnapOnAttack")]
		[REDProperty(IsIgnored = true)]
		public CBool AimSnapOnAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("aimSnapOnBlockHit")]
		[REDProperty(IsIgnored = true)]
		public CBool AimSnapOnBlockHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("aimSnapOnHit")]
		[REDProperty(IsIgnored = true)]
		public CBool AimSnapOnHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("aimSnapOnThrow")]
		[REDProperty(IsIgnored = true)]
		public CBool AimSnapOnThrow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("moveToTargetDistanceIntoAttackRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat MoveToTargetDistanceIntoAttackRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("moveToTargetEnabledAttacks")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MoveToTargetEnabledAttacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("moveToTargetSearchDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MoveToTargetSearchDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
