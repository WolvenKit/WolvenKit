
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAimAssistBulletMagnetism_Record
	{
		[RED("deadReckoningSearchAnglePitch")]
		[REDProperty(IsIgnored = true)]
		public CFloat DeadReckoningSearchAnglePitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("deadReckoningSearchAngleYaw")]
		[REDProperty(IsIgnored = true)]
		public CFloat DeadReckoningSearchAngleYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isEnabled")]
		[REDProperty(IsIgnored = true)]
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("magPointOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat MagPointOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("targetHighAngularVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat TargetHighAngularVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("targetSearchAnglePitch")]
		[REDProperty(IsIgnored = true)]
		public CFloat TargetSearchAnglePitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("targetSearchAngleYaw")]
		[REDProperty(IsIgnored = true)]
		public CFloat TargetSearchAngleYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
